using System;
using Google.GData.Client;
using Google.GData.Spreadsheets;
using MaterialSkin.Controls;
using System.Windows.Forms;

namespace DATAO
{
    public partial class GAuthForm : MaterialForm
    {

        OAuth2Parameters Parameters { get; set; } = new OAuth2Parameters();
        public ListFeed listFeed { get; set; }

        public GAuthForm()
        {
            InitializeComponent();
            webBrowser.Navigate(Authorization.CreatAauthorizationLink(Parameters));
        }

        private void GAuthForm_Load(object sender, EventArgs e)
        {
            //
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            try
            {
                listFeed = Authorization.GetTablesFeed(Parameters, webBrowser.DocumentTitle.Remove(0, 13));

                if (listFeed != null)
                {
                    Close();
                }
            }
            catch (Exception)
            {
                //
            }
        }
    }
}
