using NewsAPI.Constants;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MandarinNews
{
    public partial class Form1 : Form
    {
        public static Languages LanguageSetting { get; set; }
        public static SortBys SortSetting { get; set; }
        public static Countries CountrySetting { get; set; }
        public static Categories CategorySetting { get; set; }
        public static Color ThemeSetting { get; set; }
        public static string InterfaceLanguage { get; set; }
        public static bool isOnlyTodaysNews { get; set; }

        public static List<string> Sources { get; set; } = new List<string>();

        public static bool isParamChanged { get; set; }

        public static string searchText { get; set; }



        UC_AllNews uc_allNews;
        UC_Settings uc_settings;
        UC_Home uc_home;
        UC_Sources uc_sources;

        public Form1()
        {
            InitializeComponent();

            LanguageSetting = Languages.RU;
            CountrySetting = Countries.RU;
            SortSetting = SortBys.PublishedAt;
            CategorySetting = 0;
            ThemeSetting = Color.DeepSkyBlue;
            InterfaceLanguage = "en";
            isOnlyTodaysNews = false;
            Sources.Add("");

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
            FillPanel.Controls["UC_Home"].BringToFront();
        }

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
            textBox1.BackColor = ThemeSetting;
            button5.BackColor = ThemeSetting;

            if (ThemeSetting == Color.Black || ThemeSetting == Color.DarkBlue)
            {
                textBox1.ForeColor = Color.White;
                button2.ForeColor = Color.White;
                button3.ForeColor = Color.White;

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

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Search...")
                textBox1.Text = "";

            if (textBox1.Text != "" && textBox1.Text != "Search...")
                searchText = textBox1.Text;
            else
                searchText = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            isParamChanged = true;

            if (textBox1.Text == "Search...")
                textBox1.Text = "";

            if (textBox1.Text != "" && textBox1.Text != "Search...")
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

                if (textBox1.Text != "" && textBox1.Text != "Search...")
                {
                    searchText = textBox1.Text;


                    uc_allNews.StartRefresh();

                    HomePanel.Visible = false;
                    SettingsPanel.Visible = false;
                    WorldPanel.Visible = true;
                    AccountPanel.Visible = false;

                    PageLbl.Text = "All news";
                    FillPanel.Controls["UC_AllNews"].BringToFront();
                }
                else
                    searchText = "";
            }
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            HomePanel.Visible = true;
            SettingsPanel.Visible = false;
            WorldPanel.Visible = false;
            AccountPanel.Visible = false;

            PageLbl.Text = "Home";

            FillPanel.Controls["UC_Home"].BringToFront();

            SetTheme();
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            HomePanel.Visible = false;
            SettingsPanel.Visible = true;
            WorldPanel.Visible = false;
            AccountPanel.Visible = false;

            PageLbl.Text = "Settings";

            FillPanel.Controls["UC_Settings"].BringToFront();

            SetTheme();
        }

        private void AllNewsBtn_Click(object sender, EventArgs e)
        {
            HomePanel.Visible = false;
            SettingsPanel.Visible = false;
            WorldPanel.Visible = true;
            AccountPanel.Visible = false;

            PageLbl.Text = "All news";

            FillPanel.Controls["UC_AllNews"].BringToFront();

            SetTheme();
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            HomePanel.Visible = false;
            SettingsPanel.Visible = false;
            WorldPanel.Visible = false;
            AccountPanel.Visible = true;

            PageLbl.Text = "Account";

            FillPanel.Controls["UC_Sources"].BringToFront();


            SetTheme();
        }

        private void button5_Click(object sender, EventArgs e)
        {
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

                PageLbl.Text = "All news";
                FillPanel.Controls["UC_AllNews"].BringToFront();
            }
            else
                searchText = "";
        }
    }
}
