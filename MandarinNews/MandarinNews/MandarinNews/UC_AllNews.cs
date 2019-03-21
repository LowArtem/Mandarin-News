using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MandarinNews
{
    public partial class UC_AllNews : UserControl
    {
        private string Authors;
        private string Description;
        private string Title;
        private string NameOfSource;
        private string URL;
        private string UrlImage;
        private string TotalResult;


        private const int PAGE_SIZE = 100;
        private string NEWS_WORD;
        private int page;
        private Model.Model model;


        public UC_AllNews()
        {
            InitializeComponent();

            model = new Model.Model();

            NEWS_WORD = "news";

            page = 1;
            NewsCountLbl.Text = page.ToString();

            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }

        /// <summary>
        /// Start refresh UC_AllNews for the search the text
        /// </summary>
        public void StartRefresh()
        {
            Form1.isParamChanged = true;

            page = 1;
            NewsCountLbl.Text = page.ToString();
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            Form1.isParamChanged = true;

            page = 1;
            NewsCountLbl.Text = page.ToString();
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
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
            if (Form1.LanguageSetting == NewsAPI.Constants.Languages.RU)
                NEWS_WORD = "новости";
            else if (Form1.LanguageSetting == NewsAPI.Constants.Languages.IT)
                NEWS_WORD = "notizie";
            else if (Form1.LanguageSetting == NewsAPI.Constants.Languages.FR)
                NEWS_WORD = "nouvelles";
            else if (Form1.LanguageSetting == NewsAPI.Constants.Languages.DE)
                NEWS_WORD = "Nachrichten";
            else if (Form1.LanguageSetting == NewsAPI.Constants.Languages.UK)
                NEWS_WORD = "новини";
            else
                NEWS_WORD = "news";

            if (Form1.isParamChanged)
            {
                if (UC_Sources.selectedMode == 0)
                {
                    if (Form1.searchText != "" && Form1.isOnlyTodaysNews)
                        model.Responce(Form1.SortSetting, Form1.LanguageSetting, DateTime.UtcNow.Date, Form1.searchText, PAGE_SIZE, page);
                    else if (Form1.searchText == "" && Form1.isOnlyTodaysNews)
                        model.Responce(Form1.SortSetting, Form1.LanguageSetting, DateTime.UtcNow.Date, NEWS_WORD, PAGE_SIZE, page);
                    else if (!Form1.isOnlyTodaysNews && Form1.searchText != "")
                        model.Responce(Form1.SortSetting, Form1.LanguageSetting, Form1.searchText, PAGE_SIZE, page);
                    else
                        model.Responce(Form1.SortSetting, Form1.LanguageSetting, NEWS_WORD, PAGE_SIZE, page);
                }
                else
                {
                    if (Form1.searchText != "" && Form1.isOnlyTodaysNews)
                        model.Responce(Form1.SortSetting, Form1.LanguageSetting, DateTime.UtcNow.Date, Form1.searchText, Form1.Sources, PAGE_SIZE, page);
                    else if (Form1.searchText == "" && Form1.isOnlyTodaysNews)
                        model.Responce(Form1.SortSetting, Form1.LanguageSetting, DateTime.UtcNow.Date, NEWS_WORD, Form1.Sources, PAGE_SIZE, page);
                    else if (!Form1.isOnlyTodaysNews && Form1.searchText != "")
                        model.Responce(Form1.SortSetting, Form1.LanguageSetting, Form1.searchText, Form1.Sources, PAGE_SIZE, page);
                    else
                        model.Responce(Form1.SortSetting, Form1.LanguageSetting, NEWS_WORD, Form1.Sources, PAGE_SIZE, page);
                }

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
            }
            else
                Authors = "Server error :(";
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
        }

        private void UC_AllNews_BackColorChanged(object sender, EventArgs e)
        {
            panel1.BackColor = this.BackColor;

            if (Form1.ThemeSetting == Color.Black || Form1.ThemeSetting == Color.DarkBlue)
            {
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label5.ForeColor = Color.White;
                label6.ForeColor = Color.White;
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
            }
            else
            {
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
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
            }
        }
    }
}
