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
        ListEntry row;
        string NameOrganization;
        public AdminForm(ListEntry row1)
        {
            InitializeComponent();
            this.row = row1;
            NameOrganization = row.Elements[4].Value.ToString();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            
            this.ChangeForm(NameOrganization);

        }

        

        private void ChangeForm(string n)
        {
            
            this.Text = "Салон красоты \""+n+"\"";
            this.Size = new System.Drawing.Size(1280, 720);
            this.pictureBox1.Visible = true;
            this.materialTabControl1.Visible = true;
            this.materialTabSelector1.Visible = true;
        }

        private void Calendar_Click(object sender, EventArgs e)
        {
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
