using System;
using MaterialSkin.Controls;
using System.Windows.Forms;


namespace DATAO
{
    public partial class AdminForm : MaterialForm
    {
        //В той форме label'ы нужно сделать из MaterialSkin
        private EventForm eventform = new EventForm();

        public AdminForm()
        {
            InitializeComponent();

            dataGridView.RowCount = 22;
            dataGridView.RowHeadersWidthSizeMode =
                DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;

            //Это все нужно делать в цикле. Потому что DRY.
            dataGridView.Rows[0].HeaderCell.Value = "09:00 - 09:30";
            dataGridView.Rows[1].HeaderCell.Value = "09:30 - 10:00";
            dataGridView.Rows[2].HeaderCell.Value = "10:00 - 10:30";
            dataGridView.Rows[3].HeaderCell.Value = "10:30 - 11:00";
            dataGridView.Rows[4].HeaderCell.Value = "11:00 - 11:30";
            dataGridView.Rows[5].HeaderCell.Value = "11:30 - 12:00";
            dataGridView.Rows[6].HeaderCell.Value = "12:00 - 12:30";
            dataGridView.Rows[7].HeaderCell.Value = "12:30 - 13:00";
            dataGridView.Rows[8].HeaderCell.Value = "13:00 - 13:30";
            dataGridView.Rows[9].HeaderCell.Value = "13:30 - 14:00";
            dataGridView.Rows[10].HeaderCell.Value = "14:00 - 14:30";
            dataGridView.Rows[11].HeaderCell.Value = "14:30 - 15:00";
            dataGridView.Rows[12].HeaderCell.Value = "15:00 - 15:30";
            dataGridView.Rows[13].HeaderCell.Value = "15:30 - 16:00";
            dataGridView.Rows[14].HeaderCell.Value = "16:00 - 16:30";
            dataGridView.Rows[15].HeaderCell.Value = "16:30 - 17:00";
            dataGridView.Rows[16].HeaderCell.Value = "17:00 - 17:30";
            dataGridView.Rows[17].HeaderCell.Value = "17:30 - 18:00";
            dataGridView.Rows[18].HeaderCell.Value = "18:00 - 18:30";
            dataGridView.Rows[19].HeaderCell.Value = "18:30 - 19:00";
            dataGridView.Rows[20].HeaderCell.Value = "19:00 - 19:30";
            dataGridView.Rows[21].HeaderCell.Value = "19:30 - 20:00";
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
