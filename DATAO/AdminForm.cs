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
            listBox1.ScrollAlwaysVisible = true;
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
            this.LoadSklad();

        }
        private void LoadSklad()
        {
            grid1.BorderStyle = BorderStyle.FixedSingle;

            grid1.ColumnsCount = 6;
            grid1.FixedRows = 1;
            grid1.Rows.Insert(0);
            grid1[0, 0] = new SourceGrid.Cells.ColumnHeader("Наименование");
            grid1[0, 1] = new SourceGrid.Cells.ColumnHeader("Артикул");
            grid1[0, 2] = new SourceGrid.Cells.ColumnHeader("Поставщик");
            grid1[0, 3] = new SourceGrid.Cells.ColumnHeader("Стоимость (руб.)");
            grid1[0, 4] = new SourceGrid.Cells.ColumnHeader("Категория");
            grid1[0, 5] = new SourceGrid.Cells.ColumnHeader("Остаток ед.");
            //for (int r = 1; r < 10; r++)
            //{
            //пример
            grid1.Rows.Insert(1);
            grid1[1, 0] = new SourceGrid.Cells.Cell("nivea for man", typeof(string));
            grid1[1, 1] = new SourceGrid.Cells.Cell(5684123413, typeof(int));
            grid1[1, 2] = new SourceGrid.Cells.Cell("ооо шампунькин", typeof(string));
            grid1[1, 3] = new SourceGrid.Cells.Cell(256, typeof(int));
            grid1[1, 4] = new SourceGrid.Cells.Cell("шампуни", typeof(CheckBox));
            grid1[1, 5] = new SourceGrid.Cells.Cell(12, typeof(int));

            //}
            grid1.AutoSizeCells();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            eventform.Show();
        }

        private void editableControlBase1_Load(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grid1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void settingButton_Click(object sender, EventArgs e)
        {
            SetForm set = new SetForm();
            set.Show();
        }

        private void newPersonalButton_Click(object sender, EventArgs e)
        {
            AddWorker add = new AddWorker();
            add.Show();
        }
    }
}
