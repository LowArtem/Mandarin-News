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
    public partial class UC_Browser : UserControl
    {
        public UC_Browser()
        {
            InitializeComponent();
        }

        public void Init()
        {
            if (UC_AllNews.isAllNews)
            {
                if (UC_AllNews.browse_url != null && UC_AllNews.browse_url != "")
                {
                    Start(UC_AllNews.browse_url);
                }
                else
                    webBrowser1 = null;
            }
            else if (UC_Home.isHome)
            {
                if (UC_Home.browse_url != null && UC_Home.browse_url != "")
                {
                    Start(UC_Home.browse_url);
                }
                else
                    webBrowser1 = null;
            }
            else
                webBrowser1 = null;
        }

        private void Start(string url)
        {
            webBrowser1.Navigate(url);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
