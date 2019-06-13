﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using CefSharp.WinForms;

namespace MandarinNews
{
    public partial class UC_Home : UserControl
    {
        private string Authors;
        private string Description;
        private string Title;
        private string NameOfSource;
        private string URL;
        private string UrlImage;
        private string TotalResult;
        private string PublishedAt;
        private string parser;


        private const int PAGE_SIZE = 80;
        private int page;
        private Model.Model model;

        public ChromiumWebBrowser Browser;

        public UC_Home()
        {
            InitializeComponent();

            ChangeColor();

            model = new Model.Model();

            CefSettings settings = new CefSettings();


            InitializeChromium("https://google.com");

            page = 1;
            NewsCountLbl.Text = page.ToString();

            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            AntiFocus.Focus();

            Form1.isParamChanged = true;

            page = 1;
            NewsCountLbl.Text = page.ToString();
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            AntiFocus.Focus();

            if (model != null)
            {
                if (Convert.ToInt32(model.TotalResult) > page)
                {
                    if (page < PAGE_SIZE)
                        page++;
                }
            }
            else
            {
                if (page < PAGE_SIZE)
                    page++;
            }

            NewsCountLbl.Text = page.ToString();

            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }

        private void PreviousBtn_Click(object sender, EventArgs e)
        {
            AntiFocus.Focus();

            if (page > 1)
                page--;

            NewsCountLbl.Text = page.ToString();

            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }

        //
        // Main program method
        //
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (Form1.isParamChanged)
                {
                    if (Form1.CountrySetting != 0 && Form1.CategorySetting != 0)
                        model.ResponseHeadlines(Form1.LanguageSetting, Form1.CountrySetting, Form1.CategorySetting, PAGE_SIZE, page);
                    else if (Form1.CountrySetting == 0 && Form1.CategorySetting != 0)
                        model.ResponseHeadlines(Form1.LanguageSetting, Form1.CategorySetting, PAGE_SIZE, page);
                    else if (Form1.CategorySetting == 0 && Form1.CountrySetting != 0)
                        model.ResponseHeadlines(Form1.LanguageSetting, Form1.CountrySetting, PAGE_SIZE, page);
                    else if (Form1.CountrySetting == 0 && Form1.CategorySetting == 0)
                        model.ResponseHeadlines(Form1.LanguageSetting, PAGE_SIZE, page);
                    else if (Form1.searchText == "" && Form1.CountrySetting != 0 && Form1.CategorySetting != 0)
                        model.ResponseHeadlines(Form1.LanguageSetting, Form1.CountrySetting, Form1.CategorySetting, PAGE_SIZE, page);
                    else if (Form1.CountrySetting == 0 && Form1.searchText == "" && Form1.CategorySetting != 0)
                        model.ResponseHeadlines(Form1.LanguageSetting, Form1.CategorySetting, PAGE_SIZE, page);
                    else if (Form1.CategorySetting == 0 && Form1.searchText == "" && Form1.CountrySetting != 0)
                        model.ResponseHeadlines(Form1.LanguageSetting, Form1.CountrySetting, PAGE_SIZE, page);
                    else
                        model.ResponseHeadlines(Form1.LanguageSetting, PAGE_SIZE, page);
                                        

                    Form1.isParamChanged = false;
                }
                else
                    model.InformationSctructuring(page);


                if (model.isStatusOk)
                {
                    Authors = model.Authors;
                    Description = model.Description;
                    Title = model.Title;
                    NameOfSource = model.NameOfSource;
                    URL = model.URL;
                    UrlImage = model.UrlImage;
                    TotalResult = model.TotalResult;
                    PublishedAt = model.PublishedAt;
                }
                else
                {
                    Title = "Server error :(";

                    Authors = "";
                    Description = "";
                    NameOfSource = "";
                    URL = "";
                    UrlImage = "";
                    TotalResult = "";
                    PublishedAt = "";
                }

                string lang = ParserLanguage();

                if (lang != "error")
                {
                    Model.Parser.ParserSettings(URL, lang);

                    string start_parser_error = Model.Parser.StartParser();
                    
                    parser = Model.Parser.ParserResult();

                    if (start_parser_error != "0")
                        parser = start_parser_error;
                }
                else
                    parser = "Parser language error :(";
            }
            catch (Exception ex)
            {
                Title = "Application error :(";
                Description = ex.Message;

                Authors = "";
                NameOfSource = "";
                URL = "";
                UrlImage = "";
                TotalResult = "";
                PublishedAt = "";
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            AuthorRTB.Text = Authors;
            DescriptionRTB.Text = Description;
            TitleRTB.Text = Title;
            SourceRTB.Text = NameOfSource;
            UrlRTB.Text = URL;
            ImageBox1.ImageLocation = UrlImage;
            ResultLbl.Text = TotalResult;
            PublishAtRTB.Text = PublishedAt;

            if (parser != "" && parser != " " && parser != null)
                DescriptionRTB.Text = parser;
        }

        private void UC_Home_BackColorChanged(object sender, EventArgs e)
        {
            ChangeColor();
        }

        private void UrlRTB_MouseClick(object sender, MouseEventArgs e)
        {
            var url = UrlRTB.Text;

            WebPanel.Visible = true;

            InitializeChromium(url);

            //System.Diagnostics.Process.Start(url);
        }

        public void ChangeColor()
        {
            panel1.BackColor = this.BackColor;
            bottomPanel.BackColor = Form1.ThemeSetting;
            rightPanel.BackColor = Form1.ThemeSetting;

            if (Form1.ThemeSetting == Color.Black || Form1.ThemeSetting == Color.DarkBlue)
            {
                /*label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label5.ForeColor = Color.White;
                label6.ForeColor = Color.White;*/
                label7.ForeColor = Color.White;
                label8.ForeColor = Color.White;

                NewsCountLbl.ForeColor = Color.White;
                ResultLbl.ForeColor = Color.White;

                PublishAtRTB.BackColor = this.BackColor;
                PublishAtRTB.ForeColor = Color.White;

                AuthorRTB.BackColor = this.BackColor;
                AuthorRTB.ForeColor = Color.White;

                TitleRTB.BackColor = this.BackColor;
                TitleRTB.ForeColor = Color.White;

                DescriptionRTB.BackColor = this.BackColor;
                DescriptionRTB.ForeColor = Color.White;

                SourceRTB.BackColor = this.BackColor;
                SourceRTB.ForeColor = Color.White;

                UrlRTB.BackColor = this.BackColor;
                UrlRTB.ForeColor = Color.White;

                bottomPanel.BackColor = Form1.ThemeSetting;
                rightPanel.BackColor = Form1.ThemeSetting;
            }
            else
            {
                /*label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;*/
                label7.ForeColor = Color.Black;
                label8.ForeColor = Color.Black;

                NewsCountLbl.ForeColor = Color.Black;
                ResultLbl.ForeColor = Color.Black;

                PublishAtRTB.BackColor = this.BackColor;
                PublishAtRTB.ForeColor = Color.Black;

                AuthorRTB.BackColor = this.BackColor;
                AuthorRTB.ForeColor = Color.Black;

                TitleRTB.BackColor = this.BackColor;
                TitleRTB.ForeColor = Color.Black;

                DescriptionRTB.BackColor = this.BackColor;
                DescriptionRTB.ForeColor = Color.Black;

                SourceRTB.BackColor = this.BackColor;
                SourceRTB.ForeColor = Color.Black;

                UrlRTB.BackColor = this.BackColor;
                UrlRTB.ForeColor = Color.Black;

                bottomPanel.BackColor = Form1.ThemeSetting;
                rightPanel.BackColor = Form1.ThemeSetting;
            }
        }

        public void SetLanguage()
        {
            if (Form1.InterfaceLanguage == "en")
            {
                label7.Text = "Results:";

                /*label1.Text = "Published At:";
                label2.Text = "Source:";
                label3.Text = "Author:";
                label4.Text = "URL:";
                label5.Text = "Title:";
                label6.Text = "Description:";*/
            }
            else
            {
                label7.Text = "Результаты:";

                /*label1.Text = "Дата публикации:";
                label2.Text = "Источник:";
                label3.Text = "Автор:";
                label4.Text = "URL:";
                label5.Text = "Заголовок:";
                label6.Text = "Описание:";*/
            }
        }

        //
        // WebPanel element
        //
        private void BackBtn_Click(object sender, EventArgs e)
        {
            AntiFocus.Focus();

            WebPanel.Visible = false;
            Browser.Dispose();
        }

        public void InitializeChromium(string url)
        {
            Browser = new ChromiumWebBrowser(url);

            BrowserPanel.Controls.Add(Browser);

            Browser.Dock = DockStyle.Fill;
            Browser.Visible = true;
            Browser.BringToFront();
        }

        private string ParserLanguage()
        {
            if (Form1.LanguageSetting == NewsAPI.Constants.Languages.RU)
                return "Russian";
            else if (Form1.LanguageSetting == NewsAPI.Constants.Languages.EN)
                return "English";
            else if (Form1.LanguageSetting == NewsAPI.Constants.Languages.DE)
                return "German";
            else if (Form1.LanguageSetting == NewsAPI.Constants.Languages.IT)
                return "Italian";
            else if (Form1.LanguageSetting == NewsAPI.Constants.Languages.FR)
                return "French";
            else if (Form1.LanguageSetting == NewsAPI.Constants.Languages.UK)
                return "Ukrainian";
            else
                return "error";
        }
    }
}
