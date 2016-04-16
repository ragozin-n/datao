using System;
using Google.GData.Client;
using Google.GData.Spreadsheets;
using MaterialSkin.Controls;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Animations;
using System.Drawing;
using System.Dynamic;

namespace DATAO
{
    public partial class AdminForm : MaterialForm
    {
        private ListFeed feed { get; set; }

        EventForm eventform = new EventForm();


        public AdminForm(ListFeed userFeed)
        {
            InitializeComponent();
            feed = userFeed;
            var row = (ListEntry)userFeed.Entries[0];
            Text = string.Format("Салон красоты \"{0}\"", row.Elements[4].Value);
            dataGridView1.RowCount = 22;
            dataGridView1.RowHeadersWidthSizeMode =
        DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.Rows[0].HeaderCell.Value = "09:00 - 09:30";
            dataGridView1.Rows[1].HeaderCell.Value = "09:30 - 10:00";
            dataGridView1.Rows[2].HeaderCell.Value = "10:00 - 10:30";
            dataGridView1.Rows[3].HeaderCell.Value = "10:30 - 11:00";
            dataGridView1.Rows[4].HeaderCell.Value = "11:00 - 11:30";
            dataGridView1.Rows[5].HeaderCell.Value = "11:30 - 12:00";
            dataGridView1.Rows[6].HeaderCell.Value = "12:00 - 12:30";
            dataGridView1.Rows[7].HeaderCell.Value = "12:30 - 13:00";
            dataGridView1.Rows[8].HeaderCell.Value = "13:00 - 13:30";
            dataGridView1.Rows[9].HeaderCell.Value = "13:30 - 14:00";
            dataGridView1.Rows[10].HeaderCell.Value = "14:00 - 14:30";
            dataGridView1.Rows[11].HeaderCell.Value = "14:30 - 15:00";
            dataGridView1.Rows[12].HeaderCell.Value = "15:00 - 15:30";
            dataGridView1.Rows[13].HeaderCell.Value = "15:30 - 16:00";
            dataGridView1.Rows[14].HeaderCell.Value = "16:00 - 16:30";
            dataGridView1.Rows[15].HeaderCell.Value = "16:30 - 17:00";
            dataGridView1.Rows[16].HeaderCell.Value = "17:00 - 17:30";
            dataGridView1.Rows[17].HeaderCell.Value = "17:30 - 18:00";
            dataGridView1.Rows[18].HeaderCell.Value = "18:00 - 18:30";
            dataGridView1.Rows[19].HeaderCell.Value = "18:30 - 19:00";
            dataGridView1.Rows[20].HeaderCell.Value = "19:00 - 19:30";
            dataGridView1.Rows[21].HeaderCell.Value = "19:30 - 20:00";
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void AddEvent_Click(object sender, EventArgs e)
        {
            
            eventform.Show();
        }

        private void EditEvent_Click(object sender, EventArgs e)
        {
            eventform.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
