using System.Runtime.InteropServices;
using System.Diagnostics;
using Backend_Data;


namespace WeatherAppUI
{
    public partial class BackPlate : Form
    {

        Boolean submitted = false;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]


        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public BackPlate()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            Backend.Main();
            StartCurrentWeather();
            StartNavBar();
            StartPastWeather();
            StartFutureWeather();
        }

        private void StartFutureWeather()
        {
            try
            {
                DayOneWeatherImg.Load(Backend.forecastTomorrow["icon"]);
                DayTwoWeatherImg.Load(Backend.forecastDayAfterTomorrow["icon"]);
            }
            catch (Exception e)
            {
                Debug.WriteLine("image not found");
            }

            DayOneLabel.Text = Convert.ToString(DateTime.Parse(Backend.forecastTomorrow["date"]).DayOfWeek) + ": ";
            DayOneTemp.Text = Backend.forecastTomorrow["avgtemp_c"] + "°C";
            DayOneDesc.Text = Backend.forecastTomorrow["text"];
            DayOneUV.Text = "UV: "+ Backend.forecastTomorrow["uv"];
            DayOneRain.Text = Backend.forecastTomorrow["daily_chance_of_rain"] + "% Chance of Rain";
            DayOneHumidity.Text = Backend.forecastTomorrow["avghumidity"] + "% Humidity";
            DayOneSnow.Text = Backend.forecastTomorrow["daily_chance_of_snow"] + "% Chance of Snow";

            DayTwoLabel.Text = Convert.ToString(DateTime.Parse(Backend.forecastDayAfterTomorrow["date"]).DayOfWeek) + ": ";
            DayTwoTemp.Text = Backend.forecastDayAfterTomorrow["avgtemp_c"] + "°C";
            DayTwoDesc.Text = Backend.forecastDayAfterTomorrow["text"];
            DayTwoUV.Text = "UV: " + Backend.forecastDayAfterTomorrow["uv"];
            DayTwoRain.Text = Backend.forecastDayAfterTomorrow["daily_chance_of_rain"] + "% Chance of Rain";
            DayTwoHumidity.Text = Backend.forecastDayAfterTomorrow["avghumidity"] + "% Humidity";
            DayTwoSnow.Text = Backend.forecastDayAfterTomorrow["daily_chance_of_snow"] + "% Chance of Snow";

        }
        private void StartCurrentWeather()
        {
            try
            {
                WeatherImg.Load(Backend.currentWeather["iconPath"]);
            }
            catch (Exception e)
            {
                Debug.WriteLine("image not found");
            }

            if ((Backend.currentWeather["headacheSeverity"] != "0") && (Backend.currentWeather["headacheSeverity"] != ""))
            {
                HeadacheReported(true);
            }

            LastUpdated.Text += Backend.currentWeather["lastUpdatedDate"];
            WeatherDescription.Text = Backend.currentWeather["description"];
            TempLabel.Text = Backend.currentWeather["temp"] + "°C";
            FeelsLikeLabel.Text = "Feels Like " + Backend.currentWeather["feelslikeTemp"] + "°C";
            WindSpeed.Text = Backend.currentWeather["windSpeed"] + " mph";
            WindDegree.Text = Backend.currentWeather["windDegree"] + " degrees " + Backend.currentWeather["windDirection"];
            PressureLabel.Text = Backend.currentWeather["pressure"] + " millibars";
            PrecipitationInch.Text = Backend.currentWeather["precipIn"] + " in";
            PrecipitationMm.Text = Backend.currentWeather["precipMm"] + " mm";
            HumidityLabel.Text = Backend.currentWeather["humidity"] + "% Humidity";
            CloudCvrLabel.Text = Backend.currentWeather["cloudCvr"] + "% Cloud Cover";
            UVlabel.Text = "UV: " + Backend.currentWeather["uv"];
            Visability.Text = "Visability: " + Backend.currentWeather["visibility"] + " miles";
            GustLabel.Text = "Gust: " + Backend.currentWeather["gust"] + "mph";
            DAQI.Text = "Pollution Rating: "+Backend.currentWeather["daqi"] +"/10";
        }
        private void StartPastWeather()
        {
            PastTemp.Text = Backend.pastData["temp_c"].ToString("0.0")+ "°C";
            PastWind.Text = Backend.pastData["wind_mph"].ToString("0") + " mph Wind";
            PastPressure.Text = Backend.pastData["pressure_mb"].ToString("0") + " mb of Air Pressure";
            PastPrecipitation.Text = Backend.pastData["precip_in"].ToString("0.0") + " Inches of Rain";
            PastHumidity.Text = Backend.pastData["humidity"].ToString("0") + "% Humidity";
            PastCloud.Text = Backend.pastData["cloud"].ToString("0") + "% Cloud Cover";
            PastPollutionLabel.Text = "Pollution Rating: " + Backend.pastData["gb-defra-index"].ToString("0") + "/10";
            Double weekHeadaches = Backend.pastData["headache_severity"];
            if (submitted)
            {
                weekHeadaches++;
            }
            if (weekHeadaches>1) 
            {
                PastHeadaches.Text = weekHeadaches + " Headaches This Week";
            }
            else if (weekHeadaches==1)
            {
                PastHeadaches.Text = weekHeadaches + " Headache This Week";
            }
            Debug.WriteLine("weekHeadaches = " + weekHeadaches);

        }

        private void StartNavBar()
        {
            NavBar.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, NavBar.Width, NavBar.Height, 25, 25));
            BtnDashboard.BackColor = Color.FromArgb(46, 51, 73);
            PnlNav.Height = BtnDashboard.Height;
            PnlNav.Top = BtnDashboard.Top;
            PnlNav.Left = BtnDashboard.Left;
            Date.Text = Backend.currentDate;
            Time.Text = Backend.currentTime;
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }




        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnDashboard.Height;
            PnlNav.Top = BtnDashboard.Top;
            PnlNav.Left = BtnDashboard.Left;
            BtnDashboard.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void BtnAnalytics_Click(object sender, EventArgs e)
        {
            BtnDashboard.BackColor = Color.FromArgb(24, 30, 54);
            PnlNav.Height = BtnAnalytics.Height;
            PnlNav.Top = BtnAnalytics.Top;
            PnlNav.Left = BtnAnalytics.Left;
            BtnAnalytics.BackColor = Color.FromArgb(46, 51, 73);

        }

        private void BtnDashboard_Leave(object sender, EventArgs e)
        {
            BtnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnAnalytics_Leave(object sender, EventArgs e)
        {
            BtnAnalytics.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            Debug.WriteLine("UPDATED");
            Backend.timeCalc();
            Time.Text = Backend.currentTime;


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void HeadacheCheck_Click(object sender, EventArgs e)
        {
            if ((Backend.currentWeather["headacheSeverity"].Equals("")) && (HeadacheCheck.Checked))
            {
                SeverityLabel.Text = "Please wait until 9am to report";
                SeverityLabel.Visible = true;
            }
            else if ((Backend.currentWeather["headacheSeverity"].Equals("")) && (!HeadacheCheck.Checked))
            {
                SeverityLabel.Visible = false;
            }
            else if (!(Backend.currentWeather["headacheSeverity"].Equals("")) && (SeverityLabel.Text.Equals("Please wait until 9am to report")))
            {
                SeverityLabel.Text = "Enter Severity[0 - 10]";
                SeverityLabel.Visible = true;
                SeverityInput.Visible = true;
                SeverityBtn.Visible = true;
            }
            else if ((submitted) && !(HeadacheCheck.Checked))
            {
                SeverityLabel.Visible = false;
                SeverityInput.Visible = false;
                SeverityBtn.Visible = false;
            }
            else if (submitted)
            {
                SeverityLabel.Text = "Enter Severity[0 - 10]";
                SeverityInput.Visible = true;
                SeverityBtn.Visible = true;
                SeverityLabel.Visible = true;
            }
            else if (HeadacheCheck.Checked)
            {
                SeverityLabel.Visible = true;
                SeverityInput.Visible = true;
                SeverityBtn.Visible = true;
            }
            else if (!(HeadacheCheck.Checked))
            {
                SeverityLabel.Visible = false;
                SeverityInput.Visible = false;
                SeverityBtn.Visible = false;
            }
                
        }

        private void SeverityBtn_Click(object sender, EventArgs e)
        {
            if (SeverityInput.Text.Trim().Length > 0)
            {
                if (Backend.submitHeadache(SeverityInput.Text).Equals("success"))
                {
                    SeverityBtn.Visible = false;
                    SeverityInput.Visible = false;
                    HeadacheCheck.Checked = false;
                    HeadacheReported(true);
                }
                else
                {
                    SeverityLabel.Text = "Error";
                }
            }

        }

        private void HeadacheReported (Boolean inputSubmitted)
        {
            Double weekHeadaches = Backend.pastData["headache_severity"];
            if ((inputSubmitted) && Backend.currentWeather["headacheSeverity"].Equals("0"))
            {
                HeadacheReport.Text = "No headache reported today";
                SeverityLabel.Visible = false;
                SeverityLabel.Text = "Enter Severity [0-10]";
                submitted = false;
                PastHeadaches.Text = weekHeadaches + " Headaches This Week";
            }
            else
            {
                submitted = true;
                weekHeadaches++;
                PastHeadaches.Text = weekHeadaches + " Headaches This Week";
                HeadacheReport.Text = "Headache severity reported: " + Backend.currentWeather["headacheSeverity"] + "/10";
                SeverityLabel.Text = "Submitted!";
                HeadacheCheck.Text = "Resubmit today's headache severity?";
            }
        }

        private void SeverityInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BackPlate_Load(object sender, EventArgs e)
        {

        }
    }
}