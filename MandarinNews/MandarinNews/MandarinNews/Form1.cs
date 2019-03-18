using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewsAPI.Constants;

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

        public static string searchText { get; set; }


        /*string Author = "";
        string Description = "";
        string Title = "";
        string NameOfSource = "";
        string TotalResult = "";
        string URL = "";
        string ImageLocation = "";*/

        public Form1()
        {
            InitializeComponent();

            LanguageSetting = Languages.RU;
            SortSetting = SortBys.PublishedAt;
            CountrySetting = Countries.RU;
            CategorySetting = 0;
            ThemeSetting = Color.DeepSkyBlue;
            InterfaceLanguage = "en";
            isOnlyTodaysNews = false;

            searchText = "";

            HomePanel.Visible = true;
            SettingsPanel.Visible = false;
            WorldPanel.Visible = false;
            AccountPanel.Visible = false;


            UC_Settings uc_settings = new UC_Settings();
            uc_settings.Dock = DockStyle.Fill;
            FillPanel.Controls.Add(uc_settings);

            UC_AllNews uc_allNews = new UC_AllNews();
            uc_allNews.BackColor = Color.WhiteSmoke;
            uc_allNews.Dock = DockStyle.Fill;
            FillPanel.Controls.Add(uc_allNews);

            UC_Home uc_home = new UC_Home();
            uc_home.BackColor = Color.WhiteSmoke;
            uc_home.Dock = DockStyle.Fill;
            FillPanel.Controls.Add(uc_home);
            FillPanel.Controls["UC_Home"].BringToFront();
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
            if (textBox1.Text == "Search...")
                textBox1.Text = "";

            if (textBox1.Text != "" && textBox1.Text != "Search...")
                searchText = textBox1.Text;
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
                    searchText = textBox1.Text;
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
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            HomePanel.Visible = false;
            SettingsPanel.Visible = true;
            WorldPanel.Visible = false;
            AccountPanel.Visible = false;

            PageLbl.Text = "Settings";

            FillPanel.Controls["UC_Settings"].BringToFront();
        }

        private void AllNewsBtn_Click(object sender, EventArgs e)
        {
            HomePanel.Visible = false;
            SettingsPanel.Visible = false;
            WorldPanel.Visible = true;
            AccountPanel.Visible = false;

            PageLbl.Text = "All news";

            FillPanel.Controls["UC_AllNews"].BringToFront();
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            HomePanel.Visible = false;
            SettingsPanel.Visible = false;
            WorldPanel.Visible = false;
            AccountPanel.Visible = true;

            PageLbl.Text = "Account";
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
