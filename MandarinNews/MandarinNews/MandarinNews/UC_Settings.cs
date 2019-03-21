using System;
using System.Drawing;
using System.Windows.Forms;

namespace MandarinNews
{
    public partial class UC_Settings : UserControl
    {
        public UC_Settings()
        {
            InitializeComponent();

            CategoryCB.SelectedIndex = 0;
            CountryCB.SelectedIndex = 0;
            SortCB.SelectedIndex = 0;
            ThemeCB.SelectedIndex = 0;
            InterfaceLanguageCB.SelectedIndex = 0;

        }


        private void CountryCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form1.isParamChanged = true;

            if (CountryCB.SelectedIndex == 0)
            {
                Form1.CountrySetting = NewsAPI.Constants.Countries.RU;
                Form1.LanguageSetting = NewsAPI.Constants.Languages.RU;
            }
            if (CountryCB.SelectedIndex == 1)
            {
                Form1.CountrySetting = NewsAPI.Constants.Countries.US;
                Form1.LanguageSetting = NewsAPI.Constants.Languages.EN;
            }
            if (CountryCB.SelectedIndex == 2)
            {
                Form1.CountrySetting = NewsAPI.Constants.Countries.GB;
                Form1.LanguageSetting = NewsAPI.Constants.Languages.EN;
            }
            if (CountryCB.SelectedIndex == 3)
            {
                Form1.CountrySetting = NewsAPI.Constants.Countries.FR;
                Form1.LanguageSetting = NewsAPI.Constants.Languages.FR;
            }
            if (CountryCB.SelectedIndex == 4)
            {
                Form1.CountrySetting = NewsAPI.Constants.Countries.DE;
                Form1.LanguageSetting = NewsAPI.Constants.Languages.DE;
            }
            if (CountryCB.SelectedIndex == 5)
            {
                Form1.CountrySetting = NewsAPI.Constants.Countries.UA;
                Form1.LanguageSetting = NewsAPI.Constants.Languages.UK;
            }
            if (CountryCB.SelectedIndex == 6)
            {
                Form1.CountrySetting = NewsAPI.Constants.Countries.IT;
                Form1.LanguageSetting = NewsAPI.Constants.Languages.IT;
            }
        }

        private void SortCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form1.isParamChanged = true;

            if (SortCB.SelectedIndex == 0)
                Form1.SortSetting = NewsAPI.Constants.SortBys.Relevancy;
            if (SortCB.SelectedIndex == 1)
                Form1.SortSetting = NewsAPI.Constants.SortBys.Popularity;
            if (SortCB.SelectedIndex == 2)
                Form1.SortSetting = NewsAPI.Constants.SortBys.PublishedAt;
        }

        private void CategoryCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form1.isParamChanged = true;

            if (CategoryCB.SelectedIndex == 0)
                Form1.CategorySetting = 0; // если выбран этот параметр, значит категория пустая (все категории)
            if (CategoryCB.SelectedIndex == 1)
                Form1.CategorySetting = NewsAPI.Constants.Categories.Sports;
            if (CategoryCB.SelectedIndex == 2)
                Form1.CategorySetting = NewsAPI.Constants.Categories.Science;
            if (CategoryCB.SelectedIndex == 3)
                Form1.CategorySetting = NewsAPI.Constants.Categories.Business;
            if (CategoryCB.SelectedIndex == 4)
                Form1.CategorySetting = NewsAPI.Constants.Categories.Entertainment;
            if (CategoryCB.SelectedIndex == 5)
                Form1.CategorySetting = NewsAPI.Constants.Categories.Health;
            if (CategoryCB.SelectedIndex == 6)
                Form1.CategorySetting = NewsAPI.Constants.Categories.Technology;

        }

        private void ThemeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ThemeCB.SelectedIndex == 0)
                Form1.ThemeSetting = Color.DeepSkyBlue;
            if (ThemeCB.SelectedIndex == 1)
                Form1.ThemeSetting = Color.SpringGreen;
            if (ThemeCB.SelectedIndex == 2)
                Form1.ThemeSetting = Color.Yellow;
            if (ThemeCB.SelectedIndex == 3)
                Form1.ThemeSetting = Color.Crimson;
            if (ThemeCB.SelectedIndex == 4)
                Form1.ThemeSetting = Color.Magenta;
            if (ThemeCB.SelectedIndex == 5)
                Form1.ThemeSetting = Color.DarkBlue;
            if (ThemeCB.SelectedIndex == 6)
                Form1.ThemeSetting = Color.AliceBlue;
            if (ThemeCB.SelectedIndex == 7)
                Form1.ThemeSetting = Color.Black;

        }

        private void InterfaceLanguageCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InterfaceLanguageCB.SelectedIndex == 0)
                Form1.InterfaceLanguage = "en";
            if (InterfaceLanguageCB.SelectedIndex == 1)
                Form1.InterfaceLanguage = "ru";
        }

        private void DateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Form1.isParamChanged = true;

            if (DateCheckBox.CheckState == CheckState.Checked)
                Form1.isOnlyTodaysNews = true;
            else
                Form1.isOnlyTodaysNews = false;
        }

        private void UC_Settings_BackColorChanged(object sender, EventArgs e)
        {
            if (Form1.ThemeSetting == Color.Black || Form1.ThemeSetting == Color.DarkBlue)
            {
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label5.ForeColor = Color.White;
                label6.ForeColor = Color.White;

                CategoryCB.ForeColor = Color.White;
                CategoryCB.BackColor = this.BackColor;

                SortCB.ForeColor = Color.White;
                SortCB.BackColor = this.BackColor;

                ThemeCB.ForeColor = Color.White;
                ThemeCB.BackColor = this.BackColor;

                CountryCB.ForeColor = Color.White;
                CountryCB.BackColor = this.BackColor;

                InterfaceLanguageCB.ForeColor = Color.White;
                InterfaceLanguageCB.BackColor = this.BackColor;

                DateCheckBox.BackColor = this.BackColor;
                DateCheckBox.ForeColor = Color.White;
            }
            else
            {
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;

                CategoryCB.ForeColor = Color.Black;
                CategoryCB.BackColor = Color.WhiteSmoke;

                SortCB.ForeColor = Color.Black;
                SortCB.BackColor = Color.WhiteSmoke;

                ThemeCB.ForeColor = Color.Black;
                ThemeCB.BackColor = Color.WhiteSmoke;

                CountryCB.ForeColor = Color.Black;
                CountryCB.BackColor = Color.WhiteSmoke;

                InterfaceLanguageCB.ForeColor = Color.Black;
                InterfaceLanguageCB.BackColor = Color.WhiteSmoke;

                DateCheckBox.BackColor = Color.WhiteSmoke;
                DateCheckBox.ForeColor = Color.Black;
            }
        }
    }
}
