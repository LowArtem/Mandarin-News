using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace MandarinNews
{
    public partial class UC_Settings : UserControl
    {
        private string folderPath = @"./Files";
        private string filePath = @"settings.txt";
        string path;

        public UC_Settings()
        {
            string Lang = "";
            string Sort = "";
            string Country = "";
            string Category = "";
            string Theme = "";
            string FaceLang = "";
            string OnlyToday = "";

            InitializeComponent();

            path = Path.Combine(folderPath, filePath);

            #region Read settings file
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
                    }

                    if (Lang == "RU")
                        Form1.LanguageSetting = NewsAPI.Constants.Languages.RU;
                    else if (Lang == "EN")
                        Form1.LanguageSetting = NewsAPI.Constants.Languages.EN;
                    else if (Lang == "DE")
                        Form1.LanguageSetting = NewsAPI.Constants.Languages.DE;
                    else if (Lang == "FR")
                        Form1.LanguageSetting = NewsAPI.Constants.Languages.FR;
                    else if (Lang == "IT")
                        Form1.LanguageSetting = NewsAPI.Constants.Languages.IT;
                    else if (Lang == "UK")
                        Form1.LanguageSetting = NewsAPI.Constants.Languages.UK;


                    if (Sort == "Relevancy")
                        Form1.SortSetting = NewsAPI.Constants.SortBys.Relevancy;
                    else if (Sort == "Popularity")
                        Form1.SortSetting = NewsAPI.Constants.SortBys.Popularity;
                    else if (Sort == "PublishedAt")
                        Form1.SortSetting = NewsAPI.Constants.SortBys.PublishedAt;


                    if (Country == "RU")
                        Form1.CountrySetting = NewsAPI.Constants.Countries.RU;
                    else if (Country == "GB")
                        Form1.CountrySetting = NewsAPI.Constants.Countries.GB;
                    else if (Country == "IT")
                        Form1.CountrySetting = NewsAPI.Constants.Countries.IT;
                    else if (Country == "DE")
                        Form1.CountrySetting = NewsAPI.Constants.Countries.DE;
                    else if (Country == "US")
                        Form1.CountrySetting = NewsAPI.Constants.Countries.US;
                    else if (Country == "UA")
                        Form1.CountrySetting = NewsAPI.Constants.Countries.UA;
                    else if (Country == "FR")
                        Form1.CountrySetting = NewsAPI.Constants.Countries.FR;


                    if (Category == "Business")
                        Form1.CategorySetting = 0;
                    else if (Category == "Health")
                        Form1.CategorySetting = NewsAPI.Constants.Categories.Health;
                    else if (Category == "Science")
                        Form1.CategorySetting = NewsAPI.Constants.Categories.Science;
                    else if (Category == "Sports")
                        Form1.CategorySetting = NewsAPI.Constants.Categories.Sports;
                    else if (Category == "Entertainment")
                        Form1.CategorySetting = NewsAPI.Constants.Categories.Entertainment;
                    else if (Category == "Technology")
                        Form1.CategorySetting = NewsAPI.Constants.Categories.Technology;

                    Form1.ThemeSetting = Color.FromName(Theme);

                    Form1.InterfaceLanguage = FaceLang;

                    Form1.isOnlyTodaysNews = Convert.ToBoolean(OnlyToday);

                    reader.Close();
                    fs.Close();



                    if (Category == "Business")
                        CategoryCB.SelectedIndex = 0;
                    else if (Category == "Health")
                        CategoryCB.SelectedIndex = 4;
                    else if (Category == "Science")
                        CategoryCB.SelectedIndex = 2;
                    else if (Category == "Sports")
                        CategoryCB.SelectedIndex = 1;
                    else if (Category == "Entertainment")
                        CategoryCB.SelectedIndex = 3;
                    else if (Category == "Technology")
                        CategoryCB.SelectedIndex = 5;
                    else
                        CategoryCB.SelectedIndex = 0;


                    if (Country == "RU")
                        CountryCB.SelectedIndex = 0;
                    else if (Country == "GB")
                        CountryCB.SelectedIndex = 2;
                    else if (Country == "IT")
                        CountryCB.SelectedIndex = 6;
                    else if (Country == "DE")
                        CountryCB.SelectedIndex = 4;
                    else if (Country == "US")
                        CountryCB.SelectedIndex = 1;
                    else if (Country == "UA")
                        CountryCB.SelectedIndex = 5;
                    else if (Country == "FR")
                        CountryCB.SelectedIndex = 3;
                    else
                        CountryCB.SelectedIndex = 0;


                    if (Sort == "Relevancy")
                        SortCB.SelectedIndex = 0;
                    else if (Sort == "Popularity")
                        SortCB.SelectedIndex = 1;
                    else if (Sort == "PublishedAt")
                        SortCB.SelectedIndex = 2;
                    else
                        SortCB.SelectedIndex = 0;


                    if (Form1.ThemeSetting == Color.DeepSkyBlue)
                        ThemeCB.SelectedIndex = 0;
                    else if (Form1.ThemeSetting == Color.SpringGreen)
                        ThemeCB.SelectedIndex = 1;
                    else if (Form1.ThemeSetting == Color.Yellow)
                        ThemeCB.SelectedIndex = 2;
                    else if (Form1.ThemeSetting == Color.Crimson)
                        ThemeCB.SelectedIndex = 3;
                    else if (Form1.ThemeSetting == Color.Magenta)
                        ThemeCB.SelectedIndex = 4;
                    else if (Form1.ThemeSetting == Color.DarkBlue)
                        ThemeCB.SelectedIndex = 5;
                    else if (Form1.ThemeSetting == Color.AliceBlue)
                        ThemeCB.SelectedIndex = 6;
                    else if (Form1.ThemeSetting == Color.Black)
                        ThemeCB.SelectedIndex = 7;
                    else
                        ThemeCB.SelectedIndex = 0;


                    if (FaceLang == "en")
                        InterfaceLanguageCB.SelectedIndex = 0;
                    else if (FaceLang == "ru")
                        InterfaceLanguageCB.SelectedIndex = 1;
                    else
                        InterfaceLanguageCB.SelectedIndex = 0;

                    if (Form1.isOnlyTodaysNews)
                        DateCheckBox.CheckState = CheckState.Checked;
                    else if (!Form1.isOnlyTodaysNews)
                        DateCheckBox.CheckState = CheckState.Unchecked;
                    else
                        DateCheckBox.CheckState = CheckState.Unchecked;
                }
                catch (Exception)
                {
                    CategoryCB.SelectedIndex = 0;
                    CountryCB.SelectedIndex = 0;
                    SortCB.SelectedIndex = 0;
                    ThemeCB.SelectedIndex = 0;
                    InterfaceLanguageCB.SelectedIndex = 0;
                }
            }
            else
            {
                CategoryCB.SelectedIndex = 0;
                CountryCB.SelectedIndex = 0;
                SortCB.SelectedIndex = 0;
                ThemeCB.SelectedIndex = 0;
                InterfaceLanguageCB.SelectedIndex = 0;
            }
            #endregion

            ChangeColor();
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
                Form1.CategorySetting = NewsAPI.Constants.Categories.Entertainment;
            if (CategoryCB.SelectedIndex == 4)
                Form1.CategorySetting = NewsAPI.Constants.Categories.Health;
            if (CategoryCB.SelectedIndex == 5)
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
            ChangeColor();
        }

        private void ChangeColor()
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
