using System;
using Google.GData.Client;
using Google.GData.Spreadsheets;
using MaterialSkin.Controls;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Animations;
using System.Drawing;
using System.Dynamic;
using Google.GData.Calendar;

namespace DATAO
{
    public partial class AdminForm : MaterialForm
    {
        private ListFeed feed { get; set; }
        public AdminForm(ListFeed userFeed)
        {
            InitializeComponent();
            feed = userFeed;
            var row = (ListEntry)userFeed.Entries[0];
            Text = string.Format("Салон красоты \"{0}\"", row.Elements[4].Value);
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            //
        }

        private void Calendar_Click(object sender, EventArgs e)
        {
            //
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            //
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //
        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
