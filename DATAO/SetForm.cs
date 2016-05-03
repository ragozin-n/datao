using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            this.textBox0.Text = Table.Salon.SalonName;
            this.textBox1.Text = Table.Salon.Phone;
            this.textBox2ActualAddress.Text = Table.Salon.ActualAddress;
            this.textBox3.Text = Table.Salon.TIN;
            this.maskedTextBox1.Mask = "00000000000000000000";
            maskedTextBox1.MaskInputRejected += new MaskInputRejectedEventHandler(maskedTextBox1_MaskInputRejected);
            this.maskedTextBox1.Text = Table.Salon.AccountNumber.ToString();  
        }
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            toolTip1.ToolTipTitle = "Непраильный ввод";
            toolTip1.Show("Номер счета должен состоять из 20 цифр", maskedTextBox1, this.maskedTextBox1.Location, 5000);
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
            //for (int r = 1; r < 10; r++)
            //{
            //пример
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

            //}
            grid1.AutoSizeCells();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            Table.Salon.SalonName = this.textBox0.Text;
            Table.Salon.Phone = this.textBox1.Text;
            Table.Salon.ActualAddress = this.textBox2ActualAddress.Text;
            Table.Salon.TIN = this.textBox3.Text;
            uint accnumb = 0;
            UInt32.TryParse(this.maskedTextBox1.Text, out accnumb);
            Table.Salon.AccountNumber = accnumb;
            string[] rasp = {
                grid1[1, 0] + "-" + grid1[2, 0], grid1[1, 1] + "-" + grid1[2, 1],
                grid1[1, 2] + "-" + grid1[2, 2], grid1[1, 3] + "-" + grid1[2, 3],
                grid1[1, 4] + "-" + grid1[2, 4], grid1[1, 5] + "-" + grid1[2, 5],
                grid1[1, 6] + "-" + grid1[2, 6]
            };
            Table.Salon.SetSchedule(rasp);
            Table.Save();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
