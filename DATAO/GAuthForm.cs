using System;
using Google.GData.Client;
using Google.GData.Spreadsheets;
using MaterialSkin.Controls;
using System.Windows.Forms;

namespace DATAO
{
    public partial class GAuthForm : MaterialForm
    {
        OAuth2Parameters parameters = new OAuth2Parameters();
        public GAuthForm()
        {
            InitializeComponent();
            webBrowser.Navigate(Authorization.CreatAauthorizationLink(parameters));
        }

        private void GAuthForm_Load(object sender, EventArgs e)
        {
            //
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            ListFeed listFeed;

            try
            {
                listFeed = Authorization.GetTablesFeed(parameters, webBrowser.DocumentTitle.Remove(0, 13));

                //Берем первый ряд
                ListEntry row = (ListEntry)listFeed.Entries[0];

                //Открывается форма админа.
                MessageBox.Show($"Приветствуем, {row.Elements[1].Value.ToString()}");

                //Далее в зависимости от типа можно загрузить его страницу на диске, предварительно как-нибудь ее обозвав
                Close();
            }
            catch (Exception)
            {
                //
            }
        }
    }
}
