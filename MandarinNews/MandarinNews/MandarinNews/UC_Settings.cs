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

            LanguageCB.SelectedIndex = 0;
            CategoryCB.SelectedIndex = 0;
            CountryCB.SelectedIndex = 0;
            SortCB.SelectedIndex = 0;
            ThemeCB.SelectedIndex = 0;
            InterfaceLanguageCB.SelectedIndex = 0;
        }

        private void LanguageCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LanguageCB.SelectedIndex == 0)
                Form1.LanguageSetting = NewsAPI.Constants.Languages.RU;
            if (LanguageCB.SelectedIndex == 1)
                Form1.LanguageSetting = NewsAPI.Constants.Languages.EN;
            if (LanguageCB.SelectedIndex == 2)
                Form1.LanguageSetting = NewsAPI.Constants.Languages.FR;
            if (LanguageCB.SelectedIndex == 3)
                Form1.LanguageSetting = NewsAPI.Constants.Languages.DE;
        }

        private void CountryCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CountryCB.SelectedIndex == 0)
                Form1.CountrySetting = NewsAPI.Constants.Countries.RU;
            if (CountryCB.SelectedIndex == 1)
                Form1.CountrySetting = NewsAPI.Constants.Countries.US;
            if (CountryCB.SelectedIndex == 2)
                Form1.CountrySetting = NewsAPI.Constants.Countries.GB;
            if (CountryCB.SelectedIndex == 3)
                Form1.CountrySetting = NewsAPI.Constants.Countries.FR;
            if (CountryCB.SelectedIndex == 4)
                Form1.CountrySetting = NewsAPI.Constants.Countries.DE;
            if (CountryCB.SelectedIndex == 5)
                Form1.CountrySetting = NewsAPI.Constants.Countries.UA;
            if (CountryCB.SelectedIndex == 6)
                Form1.CountrySetting = 0; // если выбран этот параметр, значит страна пустая (все страны)
        }

        private void SortCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SortCB.SelectedIndex == 0)
                Form1.SortSetting = NewsAPI.Constants.SortBys.Relevancy;
            if (SortCB.SelectedIndex == 1)
                Form1.SortSetting = NewsAPI.Constants.SortBys.Popularity;
            if (SortCB.SelectedIndex == 2)
                Form1.SortSetting = NewsAPI.Constants.SortBys.PublishedAt;
        }

        private void CategoryCB_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            if (DateCheckBox.CheckState == CheckState.Checked)
                Form1.isOnlyTodaysNews = true;
            else
                Form1.isOnlyTodaysNews = false;
        }
    }
}
