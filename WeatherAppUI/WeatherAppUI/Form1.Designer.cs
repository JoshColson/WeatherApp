using System.Diagnostics;
using System.Drawing.Drawing2D;
using Backend_Data;
namespace WeatherAppUI
{
    partial class BackPlate
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        /// 

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.NavBar = new System.Windows.Forms.Panel();
            this.PnlNav = new System.Windows.Forms.Panel();
            this.BtnAnalytics = new System.Windows.Forms.Button();
            this.BtnDashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Time = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.WeatherImg = new System.Windows.Forms.PictureBox();
            this.CurrentWeather = new System.Windows.Forms.Panel();
            this.PressureTitle = new System.Windows.Forms.Label();
            this.WindTitle = new System.Windows.Forms.Label();
            this.TempTitle = new System.Windows.Forms.Label();
            this.MoreLabel = new System.Windows.Forms.Label();
            this.PrecipitationTitle = new System.Windows.Forms.Label();
            this.PrecipitationInch = new System.Windows.Forms.Label();
            this.PrecipitationMm = new System.Windows.Forms.Label();
            this.DAQI = new System.Windows.Forms.Label();
            this.PressureLabel = new System.Windows.Forms.Label();
            this.CloudCvrLabel = new System.Windows.Forms.Label();
            this.HumidityLabel = new System.Windows.Forms.Label();
            this.Visability = new System.Windows.Forms.Label();
            this.UVlabel = new System.Windows.Forms.Label();
            this.GustLabel = new System.Windows.Forms.Label();
            this.WindDegree = new System.Windows.Forms.Label();
            this.WeatherDescription = new System.Windows.Forms.Label();
            this.WindSpeed = new System.Windows.Forms.Label();
            this.FeelsLikeLabel = new System.Windows.Forms.Label();
            this.TempLabel = new System.Windows.Forms.Label();
            this.SeverityBtn = new System.Windows.Forms.Button();
            this.SeverityInput = new System.Windows.Forms.TextBox();
            this.HeadacheReport = new System.Windows.Forms.Label();
            this.SeverityLabel = new System.Windows.Forms.Label();
            this.HeadacheCheck = new System.Windows.Forms.CheckBox();
            this.LastUpdated = new System.Windows.Forms.Label();
            this.CurrentReport = new System.Windows.Forms.Label();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.PastWeather = new System.Windows.Forms.Panel();
            this.PastReport = new System.Windows.Forms.Label();
            this.PastHeadaches = new System.Windows.Forms.Label();
            this.PastWind = new System.Windows.Forms.Label();
            this.PastCloud = new System.Windows.Forms.Label();
            this.PastHumidity = new System.Windows.Forms.Label();
            this.PastPrecipitation = new System.Windows.Forms.Label();
            this.PastPressure = new System.Windows.Forms.Label();
            this.PastTemp = new System.Windows.Forms.Label();
            this.PastPollutionLabel = new System.Windows.Forms.Label();
            this.FutureWeather = new System.Windows.Forms.Panel();
            this.FutureReport = new System.Windows.Forms.Label();
            this.DayTwoLabel = new System.Windows.Forms.Label();
            this.DayTwoSnow = new System.Windows.Forms.Label();
            this.DayOneSnow = new System.Windows.Forms.Label();
            this.DayOneLabel = new System.Windows.Forms.Label();
            this.DayTwoHumidity = new System.Windows.Forms.Label();
            this.DayOneHumidity = new System.Windows.Forms.Label();
            this.DayTwoRain = new System.Windows.Forms.Label();
            this.DayTwoWeatherImg = new System.Windows.Forms.PictureBox();
            this.DayOneRain = new System.Windows.Forms.Label();
            this.DayTwoUV = new System.Windows.Forms.Label();
            this.DayOneWeatherImg = new System.Windows.Forms.PictureBox();
            this.DayOneUV = new System.Windows.Forms.Label();
            this.DayTwoTemp = new System.Windows.Forms.Label();
            this.DayTwoDesc = new System.Windows.Forms.Label();
            this.DayOneTemp = new System.Windows.Forms.Label();
            this.DayOneDesc = new System.Windows.Forms.Label();
            this.NavBar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WeatherImg)).BeginInit();
            this.CurrentWeather.SuspendLayout();
            this.PastWeather.SuspendLayout();
            this.FutureWeather.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DayTwoWeatherImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DayOneWeatherImg)).BeginInit();
            this.SuspendLayout();
            // 
            // NavBar
            // 
            this.NavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.NavBar.Controls.Add(this.PnlNav);
            this.NavBar.Controls.Add(this.BtnAnalytics);
            this.NavBar.Controls.Add(this.BtnDashboard);
            this.NavBar.Controls.Add(this.panel2);
            this.NavBar.Location = new System.Drawing.Point(40, 34);
            this.NavBar.Name = "NavBar";
            this.NavBar.Size = new System.Drawing.Size(186, 202);
            this.NavBar.TabIndex = 0;
            // 
            // PnlNav
            // 
            this.PnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.PnlNav.Location = new System.Drawing.Point(0, 145);
            this.PnlNav.Name = "PnlNav";
            this.PnlNav.Size = new System.Drawing.Size(3, 50);
            this.PnlNav.TabIndex = 3;
            // 
            // BtnAnalytics
            // 
            this.BtnAnalytics.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnAnalytics.FlatAppearance.BorderSize = 0;
            this.BtnAnalytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnalytics.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAnalytics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnAnalytics.Location = new System.Drawing.Point(0, 149);
            this.BtnAnalytics.Name = "BtnAnalytics";
            this.BtnAnalytics.Size = new System.Drawing.Size(186, 53);
            this.BtnAnalytics.TabIndex = 2;
            this.BtnAnalytics.Text = "Analytics";
            this.BtnAnalytics.UseVisualStyleBackColor = true;
            this.BtnAnalytics.Click += new System.EventHandler(this.BtnAnalytics_Click);
            this.BtnAnalytics.Leave += new System.EventHandler(this.BtnAnalytics_Leave);
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.FlatAppearance.BorderSize = 0;
            this.BtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDashboard.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnDashboard.Location = new System.Drawing.Point(0, 107);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Size = new System.Drawing.Size(186, 42);
            this.BtnDashboard.TabIndex = 2;
            this.BtnDashboard.Text = "Dashboard";
            this.BtnDashboard.UseVisualStyleBackColor = true;
            this.BtnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            this.BtnDashboard.Leave += new System.EventHandler(this.BtnDashboard_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Time);
            this.panel2.Controls.Add(this.Date);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 107);
            this.panel2.TabIndex = 0;
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Time.Location = new System.Drawing.Point(7, 49);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(40, 17);
            this.Time.TabIndex = 0;
            this.Time.Text = "00:00";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Date.Location = new System.Drawing.Point(7, 25);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(37, 17);
            this.Date.TabIndex = 0;
            this.Date.Text = "Date";
            // 
            // WeatherImg
            // 
            this.WeatherImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.WeatherImg.Location = new System.Drawing.Point(875, 12);
            this.WeatherImg.MinimumSize = new System.Drawing.Size(64, 64);
            this.WeatherImg.Name = "WeatherImg";
            this.WeatherImg.Size = new System.Drawing.Size(64, 64);
            this.WeatherImg.TabIndex = 0;
            this.WeatherImg.TabStop = false;
            this.WeatherImg.WaitOnLoad = true;
            // 
            // CurrentWeather
            // 
            this.CurrentWeather.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(64)))), ((int)(((byte)(92)))));
            this.CurrentWeather.Controls.Add(this.NavBar);
            this.CurrentWeather.Controls.Add(this.PressureTitle);
            this.CurrentWeather.Controls.Add(this.WindTitle);
            this.CurrentWeather.Controls.Add(this.TempTitle);
            this.CurrentWeather.Controls.Add(this.MoreLabel);
            this.CurrentWeather.Controls.Add(this.PrecipitationTitle);
            this.CurrentWeather.Controls.Add(this.PrecipitationInch);
            this.CurrentWeather.Controls.Add(this.PrecipitationMm);
            this.CurrentWeather.Controls.Add(this.DAQI);
            this.CurrentWeather.Controls.Add(this.PressureLabel);
            this.CurrentWeather.Controls.Add(this.CloudCvrLabel);
            this.CurrentWeather.Controls.Add(this.HumidityLabel);
            this.CurrentWeather.Controls.Add(this.Visability);
            this.CurrentWeather.Controls.Add(this.UVlabel);
            this.CurrentWeather.Controls.Add(this.GustLabel);
            this.CurrentWeather.Controls.Add(this.WindDegree);
            this.CurrentWeather.Controls.Add(this.WeatherDescription);
            this.CurrentWeather.Controls.Add(this.WindSpeed);
            this.CurrentWeather.Controls.Add(this.FeelsLikeLabel);
            this.CurrentWeather.Controls.Add(this.TempLabel);
            this.CurrentWeather.Controls.Add(this.SeverityBtn);
            this.CurrentWeather.Controls.Add(this.SeverityInput);
            this.CurrentWeather.Controls.Add(this.HeadacheReport);
            this.CurrentWeather.Controls.Add(this.SeverityLabel);
            this.CurrentWeather.Controls.Add(this.HeadacheCheck);
            this.CurrentWeather.Controls.Add(this.WeatherImg);
            this.CurrentWeather.Controls.Add(this.LastUpdated);
            this.CurrentWeather.Controls.Add(this.CurrentReport);
            this.CurrentWeather.Dock = System.Windows.Forms.DockStyle.Top;
            this.CurrentWeather.Location = new System.Drawing.Point(0, 0);
            this.CurrentWeather.Name = "CurrentWeather";
            this.CurrentWeather.Size = new System.Drawing.Size(951, 331);
            this.CurrentWeather.TabIndex = 1;
            // 
            // PressureTitle
            // 
            this.PressureTitle.AutoSize = true;
            this.PressureTitle.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PressureTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(148)))), ((int)(((byte)(196)))));
            this.PressureTitle.Location = new System.Drawing.Point(499, 120);
            this.PressureTitle.Name = "PressureTitle";
            this.PressureTitle.Size = new System.Drawing.Size(108, 21);
            this.PressureTitle.TabIndex = 7;
            this.PressureTitle.Text = "Air Pressure: ";
            this.PressureTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // WindTitle
            // 
            this.WindTitle.AutoSize = true;
            this.WindTitle.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WindTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(148)))), ((int)(((byte)(196)))));
            this.WindTitle.Location = new System.Drawing.Point(397, 120);
            this.WindTitle.Name = "WindTitle";
            this.WindTitle.Size = new System.Drawing.Size(55, 21);
            this.WindTitle.TabIndex = 7;
            this.WindTitle.Text = "Wind:";
            this.WindTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // TempTitle
            // 
            this.TempTitle.AutoSize = true;
            this.TempTitle.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TempTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(148)))), ((int)(((byte)(196)))));
            this.TempTitle.Location = new System.Drawing.Point(255, 120);
            this.TempTitle.Name = "TempTitle";
            this.TempTitle.Size = new System.Drawing.Size(110, 21);
            this.TempTitle.TabIndex = 7;
            this.TempTitle.Text = "Temperature:";
            this.TempTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // MoreLabel
            // 
            this.MoreLabel.AutoSize = true;
            this.MoreLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(148)))), ((int)(((byte)(196)))));
            this.MoreLabel.Location = new System.Drawing.Point(785, 120);
            this.MoreLabel.Name = "MoreLabel";
            this.MoreLabel.Size = new System.Drawing.Size(54, 21);
            this.MoreLabel.TabIndex = 7;
            this.MoreLabel.Text = "More:";
            this.MoreLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // PrecipitationTitle
            // 
            this.PrecipitationTitle.AutoSize = true;
            this.PrecipitationTitle.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PrecipitationTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(148)))), ((int)(((byte)(196)))));
            this.PrecipitationTitle.Location = new System.Drawing.Point(637, 120);
            this.PrecipitationTitle.Name = "PrecipitationTitle";
            this.PrecipitationTitle.Size = new System.Drawing.Size(113, 21);
            this.PrecipitationTitle.TabIndex = 7;
            this.PrecipitationTitle.Text = "Precipitation:";
            this.PrecipitationTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // PrecipitationInch
            // 
            this.PrecipitationInch.AutoSize = true;
            this.PrecipitationInch.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PrecipitationInch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(97)))), ((int)(((byte)(158)))));
            this.PrecipitationInch.Location = new System.Drawing.Point(635, 160);
            this.PrecipitationInch.Name = "PrecipitationInch";
            this.PrecipitationInch.Size = new System.Drawing.Size(31, 17);
            this.PrecipitationInch.TabIndex = 7;
            this.PrecipitationInch.Text = "0 in";
            this.PrecipitationInch.Click += new System.EventHandler(this.label1_Click);
            // 
            // PrecipitationMm
            // 
            this.PrecipitationMm.AutoSize = true;
            this.PrecipitationMm.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PrecipitationMm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(97)))), ((int)(((byte)(158)))));
            this.PrecipitationMm.Location = new System.Drawing.Point(635, 190);
            this.PrecipitationMm.Name = "PrecipitationMm";
            this.PrecipitationMm.Size = new System.Drawing.Size(43, 17);
            this.PrecipitationMm.TabIndex = 7;
            this.PrecipitationMm.Text = "0 mm";
            this.PrecipitationMm.Click += new System.EventHandler(this.label1_Click);
            // 
            // DAQI
            // 
            this.DAQI.AutoSize = true;
            this.DAQI.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DAQI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(97)))), ((int)(((byte)(158)))));
            this.DAQI.Location = new System.Drawing.Point(775, 160);
            this.DAQI.Name = "DAQI";
            this.DAQI.Size = new System.Drawing.Size(137, 17);
            this.DAQI.TabIndex = 7;
            this.DAQI.Text = "Pollution Rating: /10";
            this.DAQI.Click += new System.EventHandler(this.label1_Click);
            // 
            // PressureLabel
            // 
            this.PressureLabel.AutoSize = true;
            this.PressureLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PressureLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(97)))), ((int)(((byte)(158)))));
            this.PressureLabel.Location = new System.Drawing.Point(500, 160);
            this.PressureLabel.Name = "PressureLabel";
            this.PressureLabel.Size = new System.Drawing.Size(73, 17);
            this.PressureLabel.TabIndex = 7;
            this.PressureLabel.Text = "0 millibars";
            this.PressureLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // CloudCvrLabel
            // 
            this.CloudCvrLabel.AutoSize = true;
            this.CloudCvrLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CloudCvrLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(97)))), ((int)(((byte)(158)))));
            this.CloudCvrLabel.Location = new System.Drawing.Point(775, 220);
            this.CloudCvrLabel.Name = "CloudCvrLabel";
            this.CloudCvrLabel.Size = new System.Drawing.Size(105, 17);
            this.CloudCvrLabel.TabIndex = 7;
            this.CloudCvrLabel.Text = "0% Cloud Cover";
            this.CloudCvrLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // HumidityLabel
            // 
            this.HumidityLabel.AutoSize = true;
            this.HumidityLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HumidityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(97)))), ((int)(((byte)(158)))));
            this.HumidityLabel.Location = new System.Drawing.Point(635, 220);
            this.HumidityLabel.Name = "HumidityLabel";
            this.HumidityLabel.Size = new System.Drawing.Size(88, 17);
            this.HumidityLabel.TabIndex = 7;
            this.HumidityLabel.Text = "0% Humidity";
            this.HumidityLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Visability
            // 
            this.Visability.AutoSize = true;
            this.Visability.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Visability.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(97)))), ((int)(((byte)(158)))));
            this.Visability.Location = new System.Drawing.Point(775, 190);
            this.Visability.Name = "Visability";
            this.Visability.Size = new System.Drawing.Size(70, 17);
            this.Visability.TabIndex = 7;
            this.Visability.Text = "Visability ";
            this.Visability.Click += new System.EventHandler(this.label1_Click);
            // 
            // UVlabel
            // 
            this.UVlabel.AutoSize = true;
            this.UVlabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UVlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(97)))), ((int)(((byte)(158)))));
            this.UVlabel.Location = new System.Drawing.Point(775, 250);
            this.UVlabel.Name = "UVlabel";
            this.UVlabel.Size = new System.Drawing.Size(34, 17);
            this.UVlabel.TabIndex = 7;
            this.UVlabel.Text = "UV: ";
            this.UVlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // GustLabel
            // 
            this.GustLabel.AutoSize = true;
            this.GustLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GustLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(97)))), ((int)(((byte)(158)))));
            this.GustLabel.Location = new System.Drawing.Point(395, 190);
            this.GustLabel.Name = "GustLabel";
            this.GustLabel.Size = new System.Drawing.Size(83, 17);
            this.GustLabel.TabIndex = 7;
            this.GustLabel.Text = "Gust: 0 mph";
            this.GustLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // WindDegree
            // 
            this.WindDegree.AutoSize = true;
            this.WindDegree.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WindDegree.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(97)))), ((int)(((byte)(158)))));
            this.WindDegree.Location = new System.Drawing.Point(395, 220);
            this.WindDegree.Name = "WindDegree";
            this.WindDegree.Size = new System.Drawing.Size(67, 17);
            this.WindDegree.TabIndex = 7;
            this.WindDegree.Text = "0 degrees";
            this.WindDegree.Click += new System.EventHandler(this.label1_Click);
            // 
            // WeatherDescription
            // 
            this.WeatherDescription.AutoSize = true;
            this.WeatherDescription.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WeatherDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(148)))), ((int)(((byte)(196)))));
            this.WeatherDescription.Location = new System.Drawing.Point(282, 62);
            this.WeatherDescription.Name = "WeatherDescription";
            this.WeatherDescription.Size = new System.Drawing.Size(79, 17);
            this.WeatherDescription.TabIndex = 7;
            this.WeatherDescription.Text = "Description";
            this.WeatherDescription.Click += new System.EventHandler(this.label1_Click);
            // 
            // WindSpeed
            // 
            this.WindSpeed.AutoSize = true;
            this.WindSpeed.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WindSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(97)))), ((int)(((byte)(158)))));
            this.WindSpeed.Location = new System.Drawing.Point(395, 160);
            this.WindSpeed.Name = "WindSpeed";
            this.WindSpeed.Size = new System.Drawing.Size(47, 17);
            this.WindSpeed.TabIndex = 7;
            this.WindSpeed.Text = "0 mph";
            this.WindSpeed.Click += new System.EventHandler(this.label1_Click);
            // 
            // FeelsLikeLabel
            // 
            this.FeelsLikeLabel.AutoSize = true;
            this.FeelsLikeLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FeelsLikeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(97)))), ((int)(((byte)(158)))));
            this.FeelsLikeLabel.Location = new System.Drawing.Point(255, 190);
            this.FeelsLikeLabel.Name = "FeelsLikeLabel";
            this.FeelsLikeLabel.Size = new System.Drawing.Size(89, 17);
            this.FeelsLikeLabel.TabIndex = 7;
            this.FeelsLikeLabel.Text = "Feels Like 0 c";
            this.FeelsLikeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // TempLabel
            // 
            this.TempLabel.AutoSize = true;
            this.TempLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TempLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(97)))), ((int)(((byte)(158)))));
            this.TempLabel.Location = new System.Drawing.Point(255, 160);
            this.TempLabel.Name = "TempLabel";
            this.TempLabel.Size = new System.Drawing.Size(28, 17);
            this.TempLabel.TabIndex = 7;
            this.TempLabel.Text = "0°C";
            this.TempLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // SeverityBtn
            // 
            this.SeverityBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(180)))), ((int)(((byte)(212)))));
            this.SeverityBtn.FlatAppearance.BorderSize = 0;
            this.SeverityBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SeverityBtn.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SeverityBtn.Location = new System.Drawing.Point(455, 299);
            this.SeverityBtn.Name = "SeverityBtn";
            this.SeverityBtn.Size = new System.Drawing.Size(61, 23);
            this.SeverityBtn.TabIndex = 6;
            this.SeverityBtn.Text = "Submit";
            this.SeverityBtn.UseVisualStyleBackColor = false;
            this.SeverityBtn.Visible = false;
            this.SeverityBtn.Click += new System.EventHandler(this.SeverityBtn_Click);
            // 
            // SeverityInput
            // 
            this.SeverityInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(180)))), ((int)(((byte)(212)))));
            this.SeverityInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SeverityInput.Location = new System.Drawing.Point(427, 298);
            this.SeverityInput.MaxLength = 2;
            this.SeverityInput.Name = "SeverityInput";
            this.SeverityInput.Size = new System.Drawing.Size(22, 23);
            this.SeverityInput.TabIndex = 5;
            this.SeverityInput.Visible = false;
            this.SeverityInput.WordWrap = false;
            this.SeverityInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.SeverityInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SeverityInput_KeyPress);
            // 
            // HeadacheReport
            // 
            this.HeadacheReport.AutoSize = true;
            this.HeadacheReport.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeadacheReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(11)))), ((int)(((byte)(34)))));
            this.HeadacheReport.Location = new System.Drawing.Point(17, 269);
            this.HeadacheReport.MinimumSize = new System.Drawing.Size(143, 24);
            this.HeadacheReport.Name = "HeadacheReport";
            this.HeadacheReport.Size = new System.Drawing.Size(159, 24);
            this.HeadacheReport.TabIndex = 4;
            this.HeadacheReport.Text = "No headache reported";
            this.HeadacheReport.Click += new System.EventHandler(this.label2_Click);
            // 
            // SeverityLabel
            // 
            this.SeverityLabel.AutoSize = true;
            this.SeverityLabel.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SeverityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(11)))), ((int)(((byte)(34)))));
            this.SeverityLabel.Location = new System.Drawing.Point(278, 298);
            this.SeverityLabel.MinimumSize = new System.Drawing.Size(143, 24);
            this.SeverityLabel.Name = "SeverityLabel";
            this.SeverityLabel.Size = new System.Drawing.Size(143, 24);
            this.SeverityLabel.TabIndex = 4;
            this.SeverityLabel.Text = "Enter Severity [0-10]";
            this.SeverityLabel.Visible = false;
            this.SeverityLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // HeadacheCheck
            // 
            this.HeadacheCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HeadacheCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HeadacheCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HeadacheCheck.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeadacheCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(11)))), ((int)(((byte)(34)))));
            this.HeadacheCheck.Location = new System.Drawing.Point(0, 286);
            this.HeadacheCheck.Name = "HeadacheCheck";
            this.HeadacheCheck.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HeadacheCheck.Size = new System.Drawing.Size(272, 45);
            this.HeadacheCheck.TabIndex = 3;
            this.HeadacheCheck.Text = "I woke up with a headache today";
            this.HeadacheCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HeadacheCheck.UseVisualStyleBackColor = true;
            this.HeadacheCheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.HeadacheCheck.Click += new System.EventHandler(this.HeadacheCheck_Click);
            // 
            // LastUpdated
            // 
            this.LastUpdated.AutoSize = true;
            this.LastUpdated.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LastUpdated.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(148)))), ((int)(((byte)(196)))));
            this.LastUpdated.Location = new System.Drawing.Point(586, 309);
            this.LastUpdated.MinimumSize = new System.Drawing.Size(150, 13);
            this.LastUpdated.Name = "LastUpdated";
            this.LastUpdated.Size = new System.Drawing.Size(150, 13);
            this.LastUpdated.TabIndex = 2;
            this.LastUpdated.Text = "Last Updated: ";
            // 
            // CurrentReport
            // 
            this.CurrentReport.AutoSize = true;
            this.CurrentReport.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CurrentReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(148)))), ((int)(((byte)(196)))));
            this.CurrentReport.Location = new System.Drawing.Point(279, 34);
            this.CurrentReport.Name = "CurrentReport";
            this.CurrentReport.Size = new System.Drawing.Size(170, 28);
            this.CurrentReport.TabIndex = 2;
            this.CurrentReport.Text = "Current Weather";
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Enabled = true;
            this.UpdateTimer.Interval = 20000;
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // PastWeather
            // 
            this.PastWeather.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(82)))));
            this.PastWeather.Controls.Add(this.PastReport);
            this.PastWeather.Controls.Add(this.PastHeadaches);
            this.PastWeather.Controls.Add(this.PastWind);
            this.PastWeather.Controls.Add(this.PastCloud);
            this.PastWeather.Controls.Add(this.PastHumidity);
            this.PastWeather.Controls.Add(this.PastPrecipitation);
            this.PastWeather.Controls.Add(this.PastPressure);
            this.PastWeather.Controls.Add(this.PastTemp);
            this.PastWeather.Controls.Add(this.PastPollutionLabel);
            this.PastWeather.Dock = System.Windows.Forms.DockStyle.Left;
            this.PastWeather.Location = new System.Drawing.Point(0, 331);
            this.PastWeather.Name = "PastWeather";
            this.PastWeather.Size = new System.Drawing.Size(475, 246);
            this.PastWeather.TabIndex = 2;
            // 
            // PastReport
            // 
            this.PastReport.AutoSize = true;
            this.PastReport.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PastReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(148)))), ((int)(((byte)(196)))));
            this.PastReport.Location = new System.Drawing.Point(6, 11);
            this.PastReport.Name = "PastReport";
            this.PastReport.Size = new System.Drawing.Size(289, 28);
            this.PastReport.TabIndex = 2;
            this.PastReport.Text = "Last Week Weather Averages";
            // 
            // PastHeadaches
            // 
            this.PastHeadaches.AutoSize = true;
            this.PastHeadaches.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PastHeadaches.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(11)))), ((int)(((byte)(34)))));
            this.PastHeadaches.Location = new System.Drawing.Point(304, 18);
            this.PastHeadaches.MinimumSize = new System.Drawing.Size(143, 28);
            this.PastHeadaches.Name = "PastHeadaches";
            this.PastHeadaches.Size = new System.Drawing.Size(159, 28);
            this.PastHeadaches.TabIndex = 4;
            this.PastHeadaches.Text = "0 Headaches this week";
            this.PastHeadaches.Click += new System.EventHandler(this.label2_Click);
            // 
            // PastWind
            // 
            this.PastWind.AutoSize = true;
            this.PastWind.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PastWind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(97)))), ((int)(((byte)(158)))));
            this.PastWind.Location = new System.Drawing.Point(150, 200);
            this.PastWind.Name = "PastWind";
            this.PastWind.Size = new System.Drawing.Size(84, 17);
            this.PastWind.TabIndex = 7;
            this.PastWind.Text = "0 mph Wind";
            this.PastWind.Click += new System.EventHandler(this.label1_Click);
            // 
            // PastCloud
            // 
            this.PastCloud.AutoSize = true;
            this.PastCloud.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PastCloud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(97)))), ((int)(((byte)(158)))));
            this.PastCloud.Location = new System.Drawing.Point(40, 150);
            this.PastCloud.Name = "PastCloud";
            this.PastCloud.Size = new System.Drawing.Size(105, 17);
            this.PastCloud.TabIndex = 7;
            this.PastCloud.Text = "0% Cloud Cover";
            this.PastCloud.Click += new System.EventHandler(this.label1_Click);
            // 
            // PastHumidity
            // 
            this.PastHumidity.AutoSize = true;
            this.PastHumidity.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PastHumidity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(97)))), ((int)(((byte)(158)))));
            this.PastHumidity.Location = new System.Drawing.Point(260, 150);
            this.PastHumidity.Name = "PastHumidity";
            this.PastHumidity.Size = new System.Drawing.Size(88, 17);
            this.PastHumidity.TabIndex = 7;
            this.PastHumidity.Text = "0% Humidity";
            this.PastHumidity.Click += new System.EventHandler(this.label1_Click);
            // 
            // PastPrecipitation
            // 
            this.PastPrecipitation.AutoSize = true;
            this.PastPrecipitation.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PastPrecipitation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(97)))), ((int)(((byte)(158)))));
            this.PastPrecipitation.Location = new System.Drawing.Point(40, 110);
            this.PastPrecipitation.Name = "PastPrecipitation";
            this.PastPrecipitation.Size = new System.Drawing.Size(106, 17);
            this.PastPrecipitation.TabIndex = 7;
            this.PastPrecipitation.Text = "0 Inches of Rain";
            this.PastPrecipitation.Click += new System.EventHandler(this.label1_Click);
            // 
            // PastPressure
            // 
            this.PastPressure.AutoSize = true;
            this.PastPressure.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PastPressure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(97)))), ((int)(((byte)(158)))));
            this.PastPressure.Location = new System.Drawing.Point(260, 110);
            this.PastPressure.Name = "PastPressure";
            this.PastPressure.Size = new System.Drawing.Size(134, 17);
            this.PastPressure.TabIndex = 7;
            this.PastPressure.Text = "0 mb of Air Pressure";
            this.PastPressure.Click += new System.EventHandler(this.label1_Click);
            // 
            // PastTemp
            // 
            this.PastTemp.AutoSize = true;
            this.PastTemp.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PastTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(97)))), ((int)(((byte)(158)))));
            this.PastTemp.Location = new System.Drawing.Point(40, 70);
            this.PastTemp.Name = "PastTemp";
            this.PastTemp.Size = new System.Drawing.Size(28, 17);
            this.PastTemp.TabIndex = 7;
            this.PastTemp.Text = "0°C";
            this.PastTemp.Click += new System.EventHandler(this.label1_Click);
            // 
            // PastPollutionLabel
            // 
            this.PastPollutionLabel.AutoSize = true;
            this.PastPollutionLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PastPollutionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(97)))), ((int)(((byte)(158)))));
            this.PastPollutionLabel.Location = new System.Drawing.Point(260, 70);
            this.PastPollutionLabel.Name = "PastPollutionLabel";
            this.PastPollutionLabel.Size = new System.Drawing.Size(137, 17);
            this.PastPollutionLabel.TabIndex = 7;
            this.PastPollutionLabel.Text = "Pollution Rating: /10";
            this.PastPollutionLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // FutureWeather
            // 
            this.FutureWeather.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(44)))), ((int)(((byte)(69)))));
            this.FutureWeather.Controls.Add(this.FutureReport);
            this.FutureWeather.Controls.Add(this.DayTwoLabel);
            this.FutureWeather.Controls.Add(this.DayTwoSnow);
            this.FutureWeather.Controls.Add(this.DayOneSnow);
            this.FutureWeather.Controls.Add(this.DayOneLabel);
            this.FutureWeather.Controls.Add(this.DayTwoHumidity);
            this.FutureWeather.Controls.Add(this.DayOneHumidity);
            this.FutureWeather.Controls.Add(this.DayTwoRain);
            this.FutureWeather.Controls.Add(this.DayTwoWeatherImg);
            this.FutureWeather.Controls.Add(this.DayOneRain);
            this.FutureWeather.Controls.Add(this.DayTwoUV);
            this.FutureWeather.Controls.Add(this.DayOneWeatherImg);
            this.FutureWeather.Controls.Add(this.DayOneUV);
            this.FutureWeather.Controls.Add(this.DayTwoTemp);
            this.FutureWeather.Controls.Add(this.DayTwoDesc);
            this.FutureWeather.Controls.Add(this.DayOneTemp);
            this.FutureWeather.Controls.Add(this.DayOneDesc);
            this.FutureWeather.Dock = System.Windows.Forms.DockStyle.Right;
            this.FutureWeather.Location = new System.Drawing.Point(475, 331);
            this.FutureWeather.Name = "FutureWeather";
            this.FutureWeather.Size = new System.Drawing.Size(476, 246);
            this.FutureWeather.TabIndex = 3;
            // 
            // FutureReport
            // 
            this.FutureReport.AutoSize = true;
            this.FutureReport.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FutureReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(148)))), ((int)(((byte)(196)))));
            this.FutureReport.Location = new System.Drawing.Point(264, 15);
            this.FutureReport.Name = "FutureReport";
            this.FutureReport.Size = new System.Drawing.Size(197, 28);
            this.FutureReport.TabIndex = 2;
            this.FutureReport.Text = "This Week Weather";
            // 
            // DayTwoLabel
            // 
            this.DayTwoLabel.AutoSize = true;
            this.DayTwoLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DayTwoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(148)))), ((int)(((byte)(196)))));
            this.DayTwoLabel.Location = new System.Drawing.Point(89, 150);
            this.DayTwoLabel.Name = "DayTwoLabel";
            this.DayTwoLabel.Size = new System.Drawing.Size(79, 21);
            this.DayTwoLabel.TabIndex = 7;
            this.DayTwoLabel.Text = "Day Two:";
            this.DayTwoLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // DayTwoSnow
            // 
            this.DayTwoSnow.AutoSize = true;
            this.DayTwoSnow.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DayTwoSnow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(97)))), ((int)(((byte)(158)))));
            this.DayTwoSnow.Location = new System.Drawing.Point(250, 215);
            this.DayTwoSnow.Name = "DayTwoSnow";
            this.DayTwoSnow.Size = new System.Drawing.Size(128, 17);
            this.DayTwoSnow.TabIndex = 7;
            this.DayTwoSnow.Text = "0% Chance of Snow";
            this.DayTwoSnow.Click += new System.EventHandler(this.label1_Click);
            // 
            // DayOneSnow
            // 
            this.DayOneSnow.AutoSize = true;
            this.DayOneSnow.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DayOneSnow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(97)))), ((int)(((byte)(158)))));
            this.DayOneSnow.Location = new System.Drawing.Point(250, 119);
            this.DayOneSnow.Name = "DayOneSnow";
            this.DayOneSnow.Size = new System.Drawing.Size(128, 17);
            this.DayOneSnow.TabIndex = 7;
            this.DayOneSnow.Text = "0% Chance of Snow";
            this.DayOneSnow.Click += new System.EventHandler(this.label1_Click);
            // 
            // DayOneLabel
            // 
            this.DayOneLabel.AutoSize = true;
            this.DayOneLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DayOneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(148)))), ((int)(((byte)(196)))));
            this.DayOneLabel.Location = new System.Drawing.Point(88, 55);
            this.DayOneLabel.Name = "DayOneLabel";
            this.DayOneLabel.Size = new System.Drawing.Size(91, 21);
            this.DayOneLabel.TabIndex = 7;
            this.DayOneLabel.Text = "Tomorrow:";
            this.DayOneLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // DayTwoHumidity
            // 
            this.DayTwoHumidity.AutoSize = true;
            this.DayTwoHumidity.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DayTwoHumidity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(97)))), ((int)(((byte)(158)))));
            this.DayTwoHumidity.Location = new System.Drawing.Point(310, 186);
            this.DayTwoHumidity.Name = "DayTwoHumidity";
            this.DayTwoHumidity.Size = new System.Drawing.Size(88, 17);
            this.DayTwoHumidity.TabIndex = 7;
            this.DayTwoHumidity.Text = "0% Humidity";
            this.DayTwoHumidity.Click += new System.EventHandler(this.label1_Click);
            // 
            // DayOneHumidity
            // 
            this.DayOneHumidity.AutoSize = true;
            this.DayOneHumidity.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DayOneHumidity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(97)))), ((int)(((byte)(158)))));
            this.DayOneHumidity.Location = new System.Drawing.Point(310, 90);
            this.DayOneHumidity.Name = "DayOneHumidity";
            this.DayOneHumidity.Size = new System.Drawing.Size(88, 17);
            this.DayOneHumidity.TabIndex = 7;
            this.DayOneHumidity.Text = "0% Humidity";
            this.DayOneHumidity.Click += new System.EventHandler(this.label1_Click);
            // 
            // DayTwoRain
            // 
            this.DayTwoRain.AutoSize = true;
            this.DayTwoRain.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DayTwoRain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(97)))), ((int)(((byte)(158)))));
            this.DayTwoRain.Location = new System.Drawing.Point(90, 215);
            this.DayTwoRain.Name = "DayTwoRain";
            this.DayTwoRain.Size = new System.Drawing.Size(106, 17);
            this.DayTwoRain.TabIndex = 7;
            this.DayTwoRain.Text = "0 Inches of Rain";
            this.DayTwoRain.Click += new System.EventHandler(this.label1_Click);
            // 
            // DayTwoWeatherImg
            // 
            this.DayTwoWeatherImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DayTwoWeatherImg.Location = new System.Drawing.Point(6, 160);
            this.DayTwoWeatherImg.MinimumSize = new System.Drawing.Size(64, 64);
            this.DayTwoWeatherImg.Name = "DayTwoWeatherImg";
            this.DayTwoWeatherImg.Size = new System.Drawing.Size(64, 64);
            this.DayTwoWeatherImg.TabIndex = 0;
            this.DayTwoWeatherImg.TabStop = false;
            this.DayTwoWeatherImg.WaitOnLoad = true;
            // 
            // DayOneRain
            // 
            this.DayOneRain.AutoSize = true;
            this.DayOneRain.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DayOneRain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(97)))), ((int)(((byte)(158)))));
            this.DayOneRain.Location = new System.Drawing.Point(90, 119);
            this.DayOneRain.Name = "DayOneRain";
            this.DayOneRain.Size = new System.Drawing.Size(106, 17);
            this.DayOneRain.TabIndex = 7;
            this.DayOneRain.Text = "0 Inches of Rain";
            this.DayOneRain.Click += new System.EventHandler(this.label1_Click);
            // 
            // DayTwoUV
            // 
            this.DayTwoUV.AutoSize = true;
            this.DayTwoUV.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DayTwoUV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(97)))), ((int)(((byte)(158)))));
            this.DayTwoUV.Location = new System.Drawing.Point(200, 186);
            this.DayTwoUV.Name = "DayTwoUV";
            this.DayTwoUV.Size = new System.Drawing.Size(30, 17);
            this.DayTwoUV.TabIndex = 7;
            this.DayTwoUV.Text = "UV:";
            this.DayTwoUV.Click += new System.EventHandler(this.label1_Click);
            // 
            // DayOneWeatherImg
            // 
            this.DayOneWeatherImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DayOneWeatherImg.Location = new System.Drawing.Point(6, 67);
            this.DayOneWeatherImg.MinimumSize = new System.Drawing.Size(64, 64);
            this.DayOneWeatherImg.Name = "DayOneWeatherImg";
            this.DayOneWeatherImg.Size = new System.Drawing.Size(64, 64);
            this.DayOneWeatherImg.TabIndex = 0;
            this.DayOneWeatherImg.TabStop = false;
            this.DayOneWeatherImg.WaitOnLoad = true;
            // 
            // DayOneUV
            // 
            this.DayOneUV.AutoSize = true;
            this.DayOneUV.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DayOneUV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(97)))), ((int)(((byte)(158)))));
            this.DayOneUV.Location = new System.Drawing.Point(200, 90);
            this.DayOneUV.Name = "DayOneUV";
            this.DayOneUV.Size = new System.Drawing.Size(34, 17);
            this.DayOneUV.TabIndex = 7;
            this.DayOneUV.Text = "UV: ";
            this.DayOneUV.Click += new System.EventHandler(this.label1_Click);
            // 
            // DayTwoTemp
            // 
            this.DayTwoTemp.AutoSize = true;
            this.DayTwoTemp.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DayTwoTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(97)))), ((int)(((byte)(158)))));
            this.DayTwoTemp.Location = new System.Drawing.Point(90, 186);
            this.DayTwoTemp.Name = "DayTwoTemp";
            this.DayTwoTemp.Size = new System.Drawing.Size(28, 17);
            this.DayTwoTemp.TabIndex = 7;
            this.DayTwoTemp.Text = "0°C";
            this.DayTwoTemp.Click += new System.EventHandler(this.label1_Click);
            // 
            // DayTwoDesc
            // 
            this.DayTwoDesc.AutoSize = true;
            this.DayTwoDesc.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DayTwoDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(148)))), ((int)(((byte)(196)))));
            this.DayTwoDesc.Location = new System.Drawing.Point(229, 155);
            this.DayTwoDesc.Name = "DayTwoDesc";
            this.DayTwoDesc.Size = new System.Drawing.Size(79, 17);
            this.DayTwoDesc.TabIndex = 7;
            this.DayTwoDesc.Text = "Description";
            this.DayTwoDesc.Click += new System.EventHandler(this.label1_Click);
            // 
            // DayOneTemp
            // 
            this.DayOneTemp.AutoSize = true;
            this.DayOneTemp.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DayOneTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(97)))), ((int)(((byte)(158)))));
            this.DayOneTemp.Location = new System.Drawing.Point(90, 90);
            this.DayOneTemp.Name = "DayOneTemp";
            this.DayOneTemp.Size = new System.Drawing.Size(28, 17);
            this.DayOneTemp.TabIndex = 7;
            this.DayOneTemp.Text = "0°C";
            this.DayOneTemp.Click += new System.EventHandler(this.label1_Click);
            // 
            // DayOneDesc
            // 
            this.DayOneDesc.AutoSize = true;
            this.DayOneDesc.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DayOneDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(148)))), ((int)(((byte)(196)))));
            this.DayOneDesc.Location = new System.Drawing.Point(229, 59);
            this.DayOneDesc.Name = "DayOneDesc";
            this.DayOneDesc.Size = new System.Drawing.Size(79, 17);
            this.DayOneDesc.TabIndex = 7;
            this.DayOneDesc.Text = "Description";
            this.DayOneDesc.Click += new System.EventHandler(this.label1_Click);
            // 
            // BackPlate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.FutureWeather);
            this.Controls.Add(this.PastWeather);
            this.Controls.Add(this.CurrentWeather);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BackPlate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.BackPlate_Load);
            this.NavBar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WeatherImg)).EndInit();
            this.CurrentWeather.ResumeLayout(false);
            this.CurrentWeather.PerformLayout();
            this.PastWeather.ResumeLayout(false);
            this.PastWeather.PerformLayout();
            this.FutureWeather.ResumeLayout(false);
            this.FutureWeather.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DayTwoWeatherImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DayOneWeatherImg)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private Panel NavBar;
        private Panel PnlNav;
        private Button BtnAnalytics;
        private Button BtnDashboard;
        private PictureBox WeatherImg;
        private Panel CurrentWeather;
        private Label CurrentReport;
        private System.Windows.Forms.Timer UpdateTimer;
        private Label LastUpdated;
        private CheckBox HeadacheCheck;
        private TextBox SeverityInput;
        private Label SeverityLabel;
        private Button SeverityBtn;
        private Panel PastWeather;
        private Label HeadacheReport;
        private Label TempLabel;
        private Label PressureTitle;
        private Label PrecipitationTitle;
        private Label PrecipitationInch;
        private Label PrecipitationMm;
        private Label HumidityLabel;
        private Label WindDegree;
        private Label WeatherDescription;
        private Label WindSpeed;
        private Label CloudCvrLabel;
        private Label FeelsLikeLabel;
        private Label UVlabel;
        private Label Visability;
        private Label GustLabel;
        private Panel panel2;
        private Label Time;
        private Label Date;
        private Label TempTitle;
        private Label WindTitle;
        private Label PressureLabel;
        private Panel FutureWeather;
        private Label PastReport;
        private Label PastHeadaches;
        private Label PastTemp;
        private Label FutureReport;
        private Label PastWind;
        private Label PastCloud;
        private Label PastHumidity;
        private Label PastPrecipitation;
        private Label PastPressure;
        private Label MoreLabel;
        private Label DAQI;
        private Label PastPollutionLabel;
        private Label DayOneLabel;
        private Label DayTwoLabel;
        private PictureBox DayTwoWeatherImg;
        private PictureBox DayOneWeatherImg;
        private Label DayOneTemp;
        private Label DayOneDesc;
        private Label DayTwoSnow;
        private Label DayOneSnow;
        private Label DayTwoHumidity;
        private Label DayOneHumidity;
        private Label DayTwoRain;
        private Label DayOneRain;
        private Label DayTwoUV;
        private Label DayOneUV;
        private Label DayTwoTemp;
        private Label DayTwoDesc;
    }

}