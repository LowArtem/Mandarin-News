using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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


        private const int PAGE_SIZE = 40;
        private int page;

        public UC_Home()
        {
            InitializeComponent();

            page = 1;
            NewsCountLbl.Text = page.ToString();

            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }
        
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            page = 1;
            NewsCountLbl.Text = page.ToString();
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (page < PAGE_SIZE)
                page++;

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

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Model.Model model = new Model.Model();

            if (Form1.CountrySetting != 0 && Form1.CategorySetting != 0 && Form1.searchText != "")
                model.ResponceHeadlines(Form1.LanguageSetting, Form1.CountrySetting, Form1.searchText, Form1.CategorySetting, PAGE_SIZE, page);
            else if (Form1.CountrySetting == 0 && Form1.searchText != "" && Form1.CategorySetting != 0)
                model.ResponceHeadlines(Form1.LanguageSetting, Form1.searchText, Form1.CategorySetting, PAGE_SIZE, page);
            else if (Form1.CategorySetting == 0 && Form1.searchText != "" && Form1.CountrySetting != 0)
                model.ResponceHeadlines(Form1.LanguageSetting, Form1.CountrySetting, Form1.searchText, PAGE_SIZE, page);
            else if (Form1.CountrySetting == 0 && Form1.CategorySetting == 0 && Form1.searchText != "")
                model.ResponceHeadlines(Form1.LanguageSetting, Form1.searchText, PAGE_SIZE, page);
            else if (Form1.searchText == "" && Form1.CountrySetting != 0 && Form1.CategorySetting != 0)
                model.ResponceHeadlines(Form1.LanguageSetting, Form1.CountrySetting, Form1.CategorySetting, PAGE_SIZE, page);
            else if (Form1.CountrySetting == 0 && Form1.searchText == "" && Form1.CategorySetting != 0)
                model.ResponceHeadlines(Form1.LanguageSetting, Form1.CategorySetting, PAGE_SIZE, page);
            else if (Form1.CategorySetting == 0 && Form1.searchText == "" && Form1.CountrySetting != 0)
                model.ResponceHeadlines(Form1.LanguageSetting, Form1.CountrySetting, PAGE_SIZE, page);
            else
                model.ResponceHeadlines(Form1.LanguageSetting, PAGE_SIZE, page);

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
    }
}
