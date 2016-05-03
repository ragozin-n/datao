using System;
using System.Windows.Forms;
using MaterialSkin.Controls;
using ExcelManager;

namespace DATAO
{
    public partial class SetForm : MaterialForm
    {
        public SetForm()
        {
            InitializeComponent();
            loadrasp();
        }

        private void SetForm_Load(object sender, EventArgs e)
        {
            textBox0.Text = Table.Salon.SalonName;
            textBox1.Text = Table.Salon.Phone;
            textBox2ActualAddress.Text = Table.Salon.ActualAddress;
            textBox2LegfalAddress.Text = Table.Salon.LegalAddress;
            textBox3.Text = Table.Salon.TIN;
            maskedTextBox1.Mask = "00000000000000000000";
            maskedTextBox1.MaskInputRejected += new MaskInputRejectedEventHandler(maskedTextBox1_MaskInputRejected);
            maskedTextBox1.Text = Table.Salon.AccountNumber.ToString();  
        }
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            toolTip1.ToolTipTitle = "Неправильный ввод";
            toolTip1.Show("Номер счета должен состоять из 20 цифр", maskedTextBox1, maskedTextBox1.Location, 5000);
        }
        private void loadrasp()
        {
            grid1.BorderStyle = BorderStyle.FixedSingle;
            grid1.ColumnsCount = 7;
            grid1.FixedRows = 1;
            grid1.Rows.Insert(0);
            grid1[0, 0] = new SourceGrid.Cells.ColumnHeader("Понедельник");
            grid1[0, 1] = new SourceGrid.Cells.ColumnHeader("Вторник");
            grid1[0, 2] = new SourceGrid.Cells.ColumnHeader("Среда");
            grid1[0, 3] = new SourceGrid.Cells.ColumnHeader("Четверг");
            grid1[0, 4] = new SourceGrid.Cells.ColumnHeader("Пятница");
            grid1[0, 5] = new SourceGrid.Cells.ColumnHeader("Суббота");
            grid1[0, 6] = new SourceGrid.Cells.ColumnHeader("Воскресенье");

            //Условие никогда не выполнится, Table.Salon.Schedule никогда не равно null. Нужно проверять на размер.
            if (Table.Salon.Schedule != null)
            {
                grid1.Rows.Insert(1);
                for (int i = 0; i < 7; i++)
                { grid1[1, i] = new SourceGrid.Cells.Cell(Table.Salon.Schedule[i].Start, typeof(TimeSpan)); }

                grid1.Rows.Insert(2);
                for (int i = 0; i < 7; i++)
                { grid1[2, i] = new SourceGrid.Cells.Cell(Table.Salon.Schedule[i].End, typeof(TimeSpan)); }
            }
            else {
                grid1.Rows.Insert(1);
                for (int i = 0; i < 7; i++)
                { grid1[1, i] = new SourceGrid.Cells.Cell("", typeof(TimeSpan)); }
                

                grid1.Rows.Insert(2);
                for (int i = 0; i < 7; i++)
                { grid1[2, i] = new SourceGrid.Cells.Cell("", typeof(TimeSpan)); }
            }

            grid1.AutoSizeCells();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            Table.Salon.SalonName = textBox0.Text;
            Table.Salon.Phone = textBox1.Text;
            Table.Salon.ActualAddress = textBox2ActualAddress.Text;
            Table.Salon.LegalAddress = textBox2LegfalAddress.Text;
            Table.Salon.TIN = textBox3.Text;

            /*
            //Можно упростить через try
            try
            {
                Table.Salon.AccountNumber = uint.Parse(maskedTextBox1.Text);
            }
            catch (Exception ex)
            {
                //В случае если ошибка, то
                Table.Salon.AccountNumber = 0;   
            }
            */
            uint accnumb = 0;
            uint.TryParse(maskedTextBox1.Text, out accnumb);
            Table.Salon.AccountNumber = accnumb;

            //Тут тоже, наверное, можно придумать цикл
            string[] rasp = {
                grid1[1, 0] + "-" + grid1[2, 0], grid1[1, 1] + "-" + grid1[2, 1],
                grid1[1, 2] + "-" + grid1[2, 2], grid1[1, 3] + "-" + grid1[2, 3],
                grid1[1, 4] + "-" + grid1[2, 4], grid1[1, 5] + "-" + grid1[2, 5],
                grid1[1, 6] + "-" + grid1[2, 6]
            };
            Table.Salon.SetSchedule(rasp);
            Table.Save();
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
