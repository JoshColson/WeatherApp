using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Xml;

namespace Backend_Data
{
    public static class Backend
    {
        //Today Data
        public static string[]? titles;
        public static string[] morningReport = File.ReadLines(fileLocation + fileName).Last().Split(',');
        //public const string fileLocation = @"//NAS/Josh/Coding/Weather Project/";
        public const string fileLocation = @"C:/Users/Josh/Desktop/";
        public const string fileName = "WeatherReport.txt";
        public static string currentDate = "Date";
        public static string currentTime = "00:00";
        public static Dictionary<string, string> currentWeather = new Dictionary<string, string>();

        //Past Data
        public static Dictionary<string, double> pastData = new Dictionary<string, double>();

        //Future Data
        public static Dictionary<string, string> forecastTomorrow = new Dictionary<string, string>();
        public static Dictionary<string, string> forecastDayAfterTomorrow = new Dictionary<string, string>();

        //Misc
        public static DateTime pastWeek = DateTime.Today.AddDays(-7);
        public static DateTime yesterday = DateTime.Today.AddDays(-0);

        public static void Main()
        {
            pastData.Add("temp_c", 0);
            pastData.Add("wind_mph", 0);
            pastData.Add("pressure_mb", 0);
            pastData.Add("precip_in", 0);
            pastData.Add("humidity", 0);
            pastData.Add("cloud", 0);
            pastData.Add("gb-defra-index", 0);
            pastData.Add("headache_severity", 0);

            currentWeather.Add("headacheSeverity", "");


            dataCollection();
            dateCalc();
            timeCalc();
            forecastCollection();
            titles = null;
        }

        public static void forecastCollection()
        {
            string ForecastPath = "https://api.weatherapi.com/v1/forecast.xml?key=9b5a3e652b1b49839c0203506220802&q&q=Truro&days=7&aqi=no&alerts=no";
            string forecastFileName = "WeatherForecast.txt";
            XmlTextReader reader = new XmlTextReader(ForecastPath);
            string name = "";
            string value;
            bool datePlusOne = false;
            bool datePlusTwo = false;
            string[] futureDataTitles = { "date", "avgtemp_c", "text", "icon", "daily_chance_of_rain", "daily_chance_of_snow", "avghumidity", "uv" };
            List<string> pastTitles = new List<string> {};

            if (File.Exists(fileLocation + forecastFileName))
            {
                int count = 0;
                foreach (string line in System.IO.File.ReadLines(fileLocation + forecastFileName))
                {

                    if (count == 0)
                    {
                        pastTitles = line.Split(',').ToList<string>();
                    }
                    else
                    {
                        for (int i = 0; i < pastTitles.Count; i++)
                        {
                            if (count == 1)
                            {
                                forecastTomorrow.Add(pastTitles[i], line.Split(',')[i]);
                            }
                            else
                            {
                                forecastDayAfterTomorrow.Add(pastTitles[i], line.Split(',')[i]);
                            }

                        }
                    }
                    count++;
                }
            }
            if (!DateTime.Parse(forecastTomorrow["date"]).Equals(DateTime.Today.Date.AddDays(1)))
            {
                File.Delete(fileLocation + forecastFileName);
                forecastTomorrow.Clear();
                forecastDayAfterTomorrow.Clear();
            }
            else
            {
                return;
            }
            while (reader.Read())
            {
                value = reader.Value;
                try
                {
                    if (!(value.Equals("")) && (!(name.Equals(""))))
                    {
                        if (name.Equals("date"))
                        {
                            if (DateTime.Parse(value).Equals(DateTime.Today.Date.AddDays(1)))
                            {
                                datePlusOne = true;
                                datePlusTwo = false;
                                forecastTomorrow.Add(name, DateTime.Parse(value).ToString("dd/MM/yyyy"));
                            }
                            else if (DateTime.Parse(value).Equals(DateTime.Today.Date.AddDays(2)))
                            {
                                datePlusTwo = true;
                                datePlusOne = false;
                                forecastDayAfterTomorrow.Add(name, DateTime.Parse(value).ToString("dd/MM/yyyy"));
                            }
                            else
                            {
                                datePlusOne = false;
                                datePlusTwo = false;
                            }
                        }
                        if (!datePlusTwo && forecastTomorrow.Count == futureDataTitles.Length)
                        {
                            continue;
                        }
                        else if (datePlusTwo && forecastDayAfterTomorrow.Count == futureDataTitles.Length)
                        {
                            break;
                        }
                        else if (datePlusOne && futureDataTitles.Contains(name))
                        {
                            if (name.Equals("icon"))
                            {
                                forecastTomorrow.Add(name, ("http:" + value));
                            }
                            else
                            {
                                forecastTomorrow.Add(name, value);
                            }

                        }
                        else if (datePlusTwo && futureDataTitles.Contains(name))
                        {
                            if (name.Equals("icon"))
                            {
                                forecastDayAfterTomorrow.Add(name, ("http:" + value));
                            }
                            else
                            {
                                forecastDayAfterTomorrow.Add(name, value);
                            }
                        }
                    }
                }
                catch (Exception ArgumentException)
                {
                    continue;
                }

                name = reader.Name;
            }
            using (StreamWriter sw = File.CreateText(fileLocation + forecastFileName))
            {
                sw.WriteLine(string.Join(',', forecastTomorrow.Keys));
                sw.WriteLine(string.Join(',', forecastTomorrow.Values));
                sw.WriteLine(string.Join(',', forecastDayAfterTomorrow.Values));
            }
        }
        public static void dataCollection()
        {
            int readingsInPastWeek = 0;
            int lineCounter = 0;
            string[] Currentdata = File.ReadLines(fileLocation + fileName).Last().Split(',');

            foreach (string line in System.IO.File.ReadLines(fileLocation + fileName))
            {
                if (lineCounter==0)
                {
                    titles = line.Split(',');
                }

                //Populate last weeks average data
                if ((line != "") && (line.Split(',')[0].Equals("avrgData")))
                    {
                    var dateSearch = DateTime.Parse(line.Split(',')[1]);
                    if ((dateSearch.Ticks > pastWeek.Ticks) && (dateSearch.Ticks < yesterday.Ticks))
                    { 

                        readingsInPastWeek++;
                        string[] pastDataStr = line.Split((','));

                        for (int i = 0; i < pastDataStr.Length; i++)
                        {
                            if ((pastData.ContainsKey(titles[i])) && (!titles[i].Equals("headache_severity")))
                            {
                                pastData[titles[i]] += Convert.ToDouble(pastDataStr[i]);
                            }
                        }
                    }
                }
                

                //check if the current reading line is morning data
                if ((line != "") && (line.Split(',')[0].Equals("mornData")) && DateTime.Parse(line.Split(',')[1]).Date.Equals(DateTime.Now.Date))
                    {
                    //check time of entry
                    var dateSearch = DateTime.Parse(line.Split(',')[1]);
                    if (dateSearch.Date.Equals(DateTime.Now.Date))
                    {
                        //If it is then set morningdataTime (so that it can accurately be found again), save this entry, and save the headache severity
                        morningReport = line.Split(',');
                        currentWeather["headacheSeverity"] = morningReport[morningReport.Length - 1];
                    }
                    
                }
                else if ((line != "") && (line.Split(',')[0].Equals("mornData")) && (DateTime.Parse(line.Split(',')[1]).Ticks > pastWeek.Ticks) && (DateTime.Parse(line.Split(',')[1]).
                    Ticks < yesterday.Ticks))
                {
                    if (!(line.Split(',').Last().Equals("0")))
                    {
                        pastData["headache_severity"]++;
                    }
                }
                lineCounter++;
            }
            //Otherwise, if its later than 09:06AM and there isnt such a report, create one
            if ((morningReport == null) && (DateTime.Now > DateTime.Today.AddHours(9.10)))
            {
                using (StreamWriter writeLine = File.AppendText(fileLocation + fileName))
                {
                    writeLine.Write("mornData,"+DateTime.Now.ToString("dd/MM/yyyy") + " 09:00,");

                    //Add a new entry to the file with a date of today, 9am and with the same data as the latest entry
                    for (int x = 2; x < Currentdata.Length - 1; x++)
                    {
                        writeLine.Write(Currentdata[x] + ",");
                    }
                    writeLine.WriteLine("0");
                    currentWeather["headacheSeverity"] = "0";
 
                }

            }
            foreach(KeyValuePair<string, double> i in pastData)
            {
                if ((!i.Key.Equals("headache_severity")) && (!i.Key.Equals("precip_in")))
                {
                    pastData[i.Key] = i.Value / readingsInPastWeek;
                }
                
            }
            for (int i=0;i< Currentdata.Length;i++)
            {
                switch (titles[i])
                {
                    case "date":
                        currentWeather.Add("lastUpdatedDate", Currentdata[i]);
                        break;
                    case "temp_c":
                        currentWeather.Add("temp", Currentdata[i]);
                        break;
                    case "text":
                        currentWeather.Add("description", Currentdata[i]);
                        break;
                    case "icon":
                        currentWeather.Add("iconPath", Currentdata[i]);
                        break;
                    case "wind_mph":
                        currentWeather.Add("windSpeed", Currentdata[i]);
                        break;
                    case "wind_degree":
                        currentWeather.Add("windDegree", Currentdata[i]);
                        break;
                    case "wind_dir":
                        if (Currentdata[i].Equals("E"))
                        {
                            currentWeather.Add("windDirection", "East");
                        }
                        else if (Currentdata[i].Equals("S"))
                        {
                            currentWeather.Add("windDirection", "South");
                        }
                        else if (Currentdata[i].Equals("N"))
                        {

                            currentWeather.Add("windDirection", "North");
                        }
                        else if (Currentdata[i].Equals("W"))
                        {
                            currentWeather.Add("windDirection", "West");
                        }
                        else
                        {
                            currentWeather.Add("windDirection", Currentdata[i]);
                        }
                        break;
                    case "pressure_mb":
                        currentWeather.Add("pressure", Currentdata[i]);
                        break;
                    case "precip_in":
                        currentWeather.Add("precipIn", Currentdata[i]);
                        break;
                    case "precip_mm":
                        currentWeather.Add("precipMm", Currentdata[i]);
                        break;
                    case "humidity":
                        currentWeather.Add("humidity", Currentdata[i]);
                        break;
                    case "cloud":
                        currentWeather.Add("cloudCvr", Currentdata[i]);
                        break;
                    case "feelslike_c":
                        currentWeather.Add("feelslikeTemp", Currentdata[i]);
                        break;
                    case "vis_miles":
                        currentWeather.Add("visibility", Currentdata[i]);
                        break;
                    case "uv":
                        currentWeather.Add("uv", Currentdata[i]);
                        break;
                    case "gust_mph":
                        currentWeather.Add("gust", Currentdata[i]);
                        break;
                    case "gb-defra-index":
                        currentWeather.Add("daqi", Currentdata[i]);
                        break;
                    default:
                        break;


                }
            }
        }
        public static void dateCalc()
        {
            currentDate = DateTime.Now.ToString("dddd");
            currentDate += " " + DateTime.Now.Day + getDayNumberSuffix(DateTime.Now.Day.ToString());
            currentDate +=" "+ DateTime.Now.ToString("MMMM");
            
        }
        public static void timeCalc()
        {
            currentTime = DateTime.Now.ToString("hh") + ":" + DateTime.Now.ToString("mm") + " " + DateTime.Now.ToString("tt");
        }

        private static string getDayNumberSuffix(string day)
        {
            string suffix = "th";
            if (int.Parse(day) < 11 || int.Parse(day) > 20)
            {
                day = day.ToCharArray()[^1].ToString();
                switch (day)
                {
                    case "1":
                        suffix = "st";
                        break;
                    case "2":
                        suffix = "nd";
                        break;
                    case "3":
                        suffix = "rd";
                        break;
                }
            }
            return suffix;
        }

        public static string submitHeadache(string input)
        {
            int severity;
            try
            {
                severity = Int32.Parse(input);
                if ((severity >10)||(severity<0))
                {
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                return "Invalid number";
            }
            currentWeather["headacheSeverity"] = Convert.ToString(severity);

            using (StreamWriter CreateFile = File.CreateText(fileLocation + "Temp.txt"))
            {
            }

            foreach (string line in System.IO.File.ReadLines(fileLocation+fileName))
            {
                
                if ((line != "") && (line.Substring(0, 8).Equals("mornData")) && DateTime.Parse(line.Split(',')[1]).Date.Equals(DateTime.Now.Date))
                {
                    //check time of entry
                    morningReport[morningReport.Length - 1] = currentWeather["headacheSeverity"];
                    using (StreamWriter writeLine = File.AppendText(fileLocation + "Temp.txt"))
                    {
                        writeLine.WriteLine(string.Join(",", morningReport));

                    }
                     continue;
                }
            
                
                using (StreamWriter writeLine = File.AppendText(fileLocation + "Temp.txt"))
                {
                    writeLine.WriteLine(line);
                }
                

            }

            File.Delete(fileLocation + fileName);
            File.Move(fileLocation + "Temp.txt", fileLocation + fileName);

            return "success";
        }

    }
}
