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
        AdminForm adF;
        public SetForm(AdminForm af)
        {
            InitializeComponent();
            loadrasp();
            this.adF = af;
        }

        private void SetForm_Load(object sender, EventArgs e)
        {
            this.nameOrgTextBox.Text = Table.Salon.SalonName;
            this.phoneTextBox.Text = Table.Salon.Phone;
            this.actualAddressTextBox.Text = Table.Salon.ActualAddress;
            this.legfalAddressTextBox.Text = Table.Salon.LegalAddress;
            this.tinTextBox.Text = Table.Salon.TIN;
            this.accountNumberTextBox.Mask = "00000000000000000000";
            accountNumberTextBox.MaskInputRejected += new MaskInputRejectedEventHandler(accountNumberTextBox_MaskInputRejected);
            this.accountNumberTextBox.Text = Table.Salon.AccountNumber.ToString();  
        }
        private void accountNumberTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            toolTip1.ToolTipTitle = "Непраильный ввод";
            toolTip1.Show("Номер счета должен состоять из 20 цифр", accountNumberTextBox, this.accountNumberTextBox.Location, 5000);
        }
        private void loadrasp()
        {
            scheduleGrid.BorderStyle = BorderStyle.FixedSingle;
            scheduleGrid.ColumnsCount = 7;
            scheduleGrid.FixedRows = 1;
            scheduleGrid.Rows.Insert(0);
            scheduleGrid[0, 0] = new SourceGrid.Cells.ColumnHeader("Понедельник");
            scheduleGrid[0, 1] = new SourceGrid.Cells.ColumnHeader("Вторник");
            scheduleGrid[0, 2] = new SourceGrid.Cells.ColumnHeader("Среда");
            scheduleGrid[0, 3] = new SourceGrid.Cells.ColumnHeader("Четверг");
            scheduleGrid[0, 4] = new SourceGrid.Cells.ColumnHeader("Пятница");
            scheduleGrid[0, 5] = new SourceGrid.Cells.ColumnHeader("Суббота");
            scheduleGrid[0, 6] = new SourceGrid.Cells.ColumnHeader("Воскресенье");
            try
            {
                scheduleGrid.Rows.Insert(1);
                for (int i = 0; i < 7; i++)
                { scheduleGrid[1, i] = new SourceGrid.Cells.Cell(Table.Salon.Schedule[i].Start, typeof(TimeSpan)); }

                scheduleGrid.Rows.Insert(2);
                for (int i = 0; i < 7; i++)
                { scheduleGrid[2, i] = new SourceGrid.Cells.Cell(Table.Salon.Schedule[i].End, typeof(TimeSpan)); }
            }
            catch (ArgumentOutOfRangeException)
            {
                scheduleGrid.Rows.Insert(1);
                for (int i = 0; i < 7; i++)
                { scheduleGrid[1, i] = new SourceGrid.Cells.Cell("", typeof(TimeSpan)); }
                

                scheduleGrid.Rows.Insert(2);
                for (int i = 0; i < 7; i++)
                { scheduleGrid[2, i] = new SourceGrid.Cells.Cell("", typeof(TimeSpan)); }
            }
            scheduleGrid.AutoSizeCells();
        }

        private void confirmlFlatButton_Click(object sender, EventArgs e)
        {
            Table.Salon.SalonName = this.nameOrgTextBox.Text;
            Table.Salon.Phone = this.phoneTextBox.Text;
            Table.Salon.ActualAddress = this.actualAddressTextBox.Text;
            Table.Salon.LegalAddress = this.legfalAddressTextBox.Text;
            Table.Salon.TIN = this.tinTextBox.Text;
            uint accnumb = 0;
            UInt32.TryParse(this.accountNumberTextBox.Text, out accnumb);
            Table.Salon.AccountNumber = accnumb;
            string[] rasp = {
                scheduleGrid[1, 0] + "-" + scheduleGrid[2, 0], scheduleGrid[1, 1] + "-" + scheduleGrid[2, 1],
                scheduleGrid[1, 2] + "-" + scheduleGrid[2, 2], scheduleGrid[1, 3] + "-" + scheduleGrid[2, 3],
                scheduleGrid[1, 4] + "-" + scheduleGrid[2, 4], scheduleGrid[1, 5] + "-" + scheduleGrid[2, 5],
                scheduleGrid[1, 6] + "-" + scheduleGrid[2, 6]
            };
            Table.Salon.SetSchedule(rasp);
            Table.Save();
            adF.loadname();
            this.Close();
        }        
    }
}
