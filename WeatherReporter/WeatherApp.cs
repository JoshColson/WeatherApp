using System;
using System.Xml;
using System.IO;
using System.Linq;

namespace WeatherReporter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running WeatherReporter Script...");
            string URLString = $"http://api.weatherapi.com/v1/current.xml?key={key}";
            XmlTextReader reader = new XmlTextReader(URLString);
            string outputValue = "";
            string name = "";
            string value = "";
            string path;
            string[] dataToCapture = { "-desc","last_updated", "temp_c" , "text" , "icon", "wind_mph", "wind_degree", "wind_dir", "pressure_mb", "precip_mm",
            "precip_in", "humidity", "cloud", "feelslike_c", "vis_miles", "uv", "gust_mph", "gb-defra-index", "headache_severity"};

            if ((DateTime.Now>DateTime.Today.AddHours(8.90)) && (DateTime.Now<DateTime.Today.AddHours(9.10)))
            {
                outputValue = "mornData,";
            }
            else if ((Convert.ToInt32(DateTime.Now.Minute)>25) && (Convert.ToInt32(DateTime.Now.Minute) < 35))
            {
                outputValue = "avrgData,";
            }
            else
            {
                outputValue = "Data----,";
            }

            while (reader.Read())
            {
                value = reader.Value;
                if (!(value.Equals("")) && (!(name.Equals(""))))
                {
                    if (dataToCapture.Contains(name))
                    {
                        if (name.Equals("last_updated"))
                        {
                            var date = DateTime.Parse(value);
                            dataToCapture[1] = "date";
                            outputValue += date.ToString("dd/MM/yyyy") + " ";
                            outputValue += date.ToString("HH:mm") + ",";

                        }
                        else if (name.Equals("icon"))
                        {
                            outputValue += "http:" + value + ",";
                        }
                        else
                        {
                            outputValue += value + ",";
                        }
                    }
                }
                name = reader.Name;
            }
            outputValue += "0";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(string.Join(",", dataToCapture));
                    sw.WriteLine("");
                    sw.WriteLine(outputValue);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(outputValue);
                }
            }               
            Console.WriteLine("...Script Completed");
        }
    }
}