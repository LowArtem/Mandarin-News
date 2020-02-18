using NewsAPI.Constants;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using CefSharp.WinForms;
using CefSharp;

namespace MandarinNews
{
    public partial class Form1 : Form
    {
        public static Languages LanguageSetting { get; set; }
        public static SortBys SortSetting { get; set; }
        public static Categories CategorySetting { get; set; }
        public static Color ThemeSetting { get; set; }
        public static Countries CountrySetting { get; set; }
        public static string InterfaceLanguage { get; set; }
        public static bool isOnlyTodaysNews { get; set; }
        public static string RegionSetting { get; set; }

        public static List<string> Sources { get; set; } = new List<string>();

        public static bool isParamChanged { get; set; }

        public static string searchText { get; set; }

        private string folderPath = @"./Files";
        private string filePath = @"settings.txt";
        string path;

        UC_AllNews uc_allNews;
        UC_Settings uc_settings;
        UC_Home uc_home;
        UC_Sources uc_sources;

        public Form1()
        {
            InitializeComponent();

            this.AutoScaleMode = AutoScaleMode.Dpi;

            path = Path.Combine(folderPath, filePath);

            CefSettings settings = new CefSettings();

            Cef.Initialize(settings);


            LanguageSetting = Languages.RU;
            CountrySetting = Countries.RU;
            SortSetting = SortBys.PublishedAt;
            CategorySetting = 0;
            ThemeSetting = Color.DeepSkyBlue;
            InterfaceLanguage = "en";
            isOnlyTodaysNews = false;
            Sources.Add("");
            RegionSetting = "All";



            isParamChanged = true;

            searchText = "";

            HomePanel.Visible = true;
            SettingsPanel.Visible = false;
            WorldPanel.Visible = false;
            AccountPanel.Visible = false;


            uc_settings = new UC_Settings();
            uc_settings.Dock = DockStyle.Fill;
            FillPanel.Controls.Add(uc_settings);

            uc_allNews = new UC_AllNews();
            uc_allNews.Dock = DockStyle.Fill;
            FillPanel.Controls.Add(uc_allNews);

            uc_sources = new UC_Sources();
            uc_sources.Dock = DockStyle.Fill;
            FillPanel.Controls.Add(uc_sources);

            uc_sources.SelectAll();

            uc_home = new UC_Home();
            uc_home.Dock = DockStyle.Fill;
            FillPanel.Controls.Add(uc_home);
            uc_home.ChangeColor();
            FillPanel.Controls["UC_Home"].BringToFront();

            ThemeColorInit();
            SetLanguage();


            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);
            if (!File.Exists(path))
                File.Create(path);
        }

        // Form resizing 
        // 1408; 788 - normal size
        #region Form Resizing
        private int tolerance = 16;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.SizeControlPanel.Region = region;
            this.Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }
        #endregion


        /// <summary>
        /// Set a theme in this app
        /// </summary>
        public void SetTheme()
        {
            #region SetTheme...
            HeaderPanel.BackColor = ThemeSetting;
            LeftPanel.BackColor = ThemeSetting;
            homeBtn.BackColor = ThemeSetting;
            AllNewsBtn.BackColor = ThemeSetting;
            settingsBtn.BackColor = ThemeSetting;
            SignInBtn.BackColor = ThemeSetting;
            button5.BackColor = ThemeSetting;
            bottomPanel.BackColor = ThemeSetting;
            rightPanel.BackColor = ThemeSetting;

            if (ThemeSetting == Color.Black || ThemeSetting == Color.DarkBlue)
            {
                textBox1.ForeColor = Color.White;
                button2.ForeColor = Color.White;
                button3.ForeColor = Color.White;
                textBox1.BackColor = Color.FromArgb(41, 53, 65);

                uc_settings.BackColor = Color.FromArgb(41, 53, 65);
                uc_home.BackColor = Color.FromArgb(41, 53, 65);
                uc_allNews.BackColor = Color.FromArgb(41, 53, 65);
                uc_sources.BackColor = Color.FromArgb(41, 53, 65);
            }
            else
            {
                textBox1.ForeColor = Color.Black;
                button2.ForeColor = Color.Black;
                button3.ForeColor = Color.Black;

                uc_settings.BackColor = Color.White;
                uc_home.BackColor = Color.White;
                uc_allNews.BackColor = Color.White;
                uc_sources.BackColor = Color.White;

                if (ThemeSetting == Color.DeepSkyBlue)
                    textBox1.BackColor = Color.LightSkyBlue;
                if (ThemeSetting == Color.Yellow)
                    textBox1.BackColor = Color.LightYellow;
                if (ThemeSetting == Color.SpringGreen)
                    textBox1.BackColor = Color.LightGreen;
                if (ThemeSetting == Color.Crimson)
                    textBox1.BackColor = Color.PaleVioletRed;
                if (ThemeSetting == Color.Magenta)
                    textBox1.BackColor = Color.FromArgb(218, 112, 214);
                if (ThemeSetting == Color.AliceBlue)
                    textBox1.BackColor = Color.FromArgb(255, 255, 255);
            }

            if (ThemeSetting == Color.Yellow || ThemeSetting == Color.AliceBlue)
            {
                PageLbl.ForeColor = Color.DarkBlue;
                label1.ForeColor = Color.DarkOrange;

                homeBtn.BackgroundImage = Properties.Resources.icons8_home_filled_100px_1;
                settingsBtn.BackgroundImage = Properties.Resources.icons8_settings_filled_100px_1;
                AllNewsBtn.BackgroundImage = Properties.Resources.icons8_europe_filled_100px_1;
                SignInBtn.BackgroundImage = Properties.Resources.icons8_user_filled_100px;

                HomePanel.BackColor = Color.Black;
                SettingsPanel.BackColor = Color.Black;
                AccountPanel.BackColor = Color.Black;
                WorldPanel.BackColor = Color.Black;
            }
            else
            {
                PageLbl.ForeColor = Color.Wheat;
                label1.ForeColor = Color.Orange;

                homeBtn.BackgroundImage = Properties.Resources.icons8_home_filled_100px;
                settingsBtn.BackgroundImage = Properties.Resources.icons8_settings_filled_100px;
                AllNewsBtn.BackgroundImage = Properties.Resources.icons8_europe_filled_100px;
                SignInBtn.BackgroundImage = Properties.Resources.icons8_gender_neutral_user_filled_50px;

                HomePanel.BackColor = Color.White;
                SettingsPanel.BackColor = Color.White;
                AccountPanel.BackColor = Color.White;
                WorldPanel.BackColor = Color.White;
            }
            #endregion
        }

        /// <summary>
        /// Read from setting file and initialize theme color
        /// </summary>
        public void ThemeColorInit()
        {
            string Lang = "";
            string Sort = "";
            string Country = "";
            string Category = "";
            string Theme = "";
            string FaceLang = "";
            string OnlyToday = "";
            string Region = "";

            if (File.Exists(path))
            {
                try
                {
                    FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    StreamReader reader = new StreamReader(fs, System.Text.Encoding.UTF8);

                    while (!reader.EndOfStream)
                    {
                        Lang = reader.ReadLine();
                        Sort = reader.ReadLine();
                        Country = reader.ReadLine();
                        Category = reader.ReadLine();
                        Theme = reader.ReadLine();
                        FaceLang = reader.ReadLine();
                        OnlyToday = reader.ReadLine();
                        Region = reader.ReadLine();
                    }

                    reader.Close();
                    fs.Close();

                    ThemeSetting = Color.FromName(Theme);

                    SetTheme();
                }
                catch (Exception)
                {
                    ThemeSetting = Color.DeepSkyBlue;
                    SetTheme();
                }
            }
            else
            {
                ThemeSetting = Color.DeepSkyBlue;
                SetTheme();
            }
        }

        /// <summary>
        /// Set a language in this app
        /// </summary>
        private void SetLanguage()
        {
            if (InterfaceLanguage == "en")
            {
                PageLbl.Text = "Home";
                textBox1.Text = "Search...";
            }
            else
            {
                PageLbl.Text = "Главная";
                textBox1.Text = "Поиск...";
            }

            uc_settings.SetLanguage();
            uc_sources.SetLanguage();
            uc_home.SetLanguage();
            uc_allNews.SetLanguage();
        }

        //
        // Application Exit
        //
        private void button2_Click(object sender, EventArgs e)
        {
            AntiFocus.Focus();

            FileStream fs = new FileStream(path, FileMode.Truncate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fs, System.Text.Encoding.UTF8);

            writer.WriteLine(LanguageSetting.ToString());
            writer.WriteLine(SortSetting.ToString());
            writer.WriteLine(CountrySetting.ToString());
            writer.WriteLine(CategorySetting.ToString());
            writer.WriteLine(ThemeSetting.Name.ToString());
            writer.WriteLine(InterfaceLanguage.ToString());
            writer.WriteLine(isOnlyTodaysNews.ToString());
            writer.WriteLine(RegionSetting.ToString());

            writer.Close();
            fs.Close();

            Cef.Shutdown();

            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AntiFocus.Focus();

            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Search..." || textBox1.Text == "Поиск...")
                textBox1.Text = "";
            else if (textBox1.Text != "" && textBox1.Text != "Search..." && textBox1.Text != "Поиск...")
                searchText = textBox1.Text;
            else
                searchText = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            isParamChanged = true;

            //if (textBox1.Text == "Search...")
            //    textBox1.Text = "";

            if (textBox1.Text != "" && textBox1.Text != "Search..." && textBox1.Text != "Поиск...")
            {
                searchText = textBox1.Text;
            }
            else
                searchText = "";
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text == "Search...")
                    textBox1.Text = "";

                if (textBox1.Text != "" && textBox1.Text != "Search..." && textBox1.Text != "Поиск...")
                {
                    searchText = textBox1.Text;


                    uc_allNews.StartRefresh();

                    HomePanel.Visible = false;
                    SettingsPanel.Visible = false;
                    WorldPanel.Visible = true;
                    AccountPanel.Visible = false;

                    if (InterfaceLanguage == "en")
                        PageLbl.Text = "All news";
                    else
                        PageLbl.Text = "Все новости";

                    FillPanel.Controls["UC_AllNews"].BringToFront();
                }
                else
                    searchText = "";
            }
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            AntiFocus.Focus();

            HomePanel.Visible = true;
            SettingsPanel.Visible = false;
            WorldPanel.Visible = false;
            AccountPanel.Visible = false;

            FillPanel.Controls["UC_Home"].BringToFront();

            SetTheme();
            SetLanguage();

            if (InterfaceLanguage == "en")
                PageLbl.Text = "Home";
            else
                PageLbl.Text = "Главная";
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            AntiFocus.Focus();

            HomePanel.Visible = false;
            SettingsPanel.Visible = true;
            WorldPanel.Visible = false;
            AccountPanel.Visible = false;

            FillPanel.Controls["UC_Settings"].BringToFront();

            SetTheme();
            SetLanguage();

            if (InterfaceLanguage == "en")
                PageLbl.Text = "Settings";
            else
                PageLbl.Text = "Настройки";
        }

        private void AllNewsBtn_Click(object sender, EventArgs e)
        {
            AntiFocus.Focus();

            HomePanel.Visible = false;
            SettingsPanel.Visible = false;
            WorldPanel.Visible = true;
            AccountPanel.Visible = false;

            FillPanel.Controls["UC_AllNews"].BringToFront();

            SetTheme();
            SetLanguage();

            if (InterfaceLanguage == "en")
                PageLbl.Text = "All news";
            else
                PageLbl.Text = "Все новости";
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            AntiFocus.Focus();

            HomePanel.Visible = false;
            SettingsPanel.Visible = false;
            WorldPanel.Visible = false;
            AccountPanel.Visible = true;

            FillPanel.Controls["UC_Sources"].BringToFront();


            SetTheme();
            SetLanguage();

            if (InterfaceLanguage == "en")
                PageLbl.Text = "Sources";
            else
                PageLbl.Text = "Источники";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AntiFocus.Focus();

            if (textBox1.Text == "Search...")
                textBox1.Text = "";

            if (textBox1.Text != "" && textBox1.Text != "Search...")
            {
                searchText = textBox1.Text;


                uc_allNews.StartRefresh();

                HomePanel.Visible = false;
                SettingsPanel.Visible = false;
                WorldPanel.Visible = true;
                AccountPanel.Visible = false;

                if (InterfaceLanguage == "en")
                    PageLbl.Text = "All news";
                else
                    PageLbl.Text = "Все новости";

                FillPanel.Controls["UC_AllNews"].BringToFront();
            }
            else
                searchText = "";

            SetTheme();
            SetLanguage();
        }

        private void HeaderPanel_BackColorChanged(object sender, EventArgs e)
        {
            SetTheme();
            uc_allNews.ChangeColor();
            uc_home.ChangeColor();
            uc_settings.ChangeColor();
            uc_sources.ChangeColor();                       
        }
    }
}
