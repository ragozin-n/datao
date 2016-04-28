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

namespace DATAO
{
    public partial class AddWorker : MaterialForm
    {
        public AddWorker()
        {
            InitializeComponent();
        }

        private void AddWorker_Load(object sender, EventArgs e)
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
            grid1.Rows.Insert(1);
            grid1[1, 0] = new SourceGrid.Cells.Cell("", typeof(CheckBox));
            grid1[1, 1] = new SourceGrid.Cells.Cell("", typeof(CheckBox));
            grid1[1, 2] = new SourceGrid.Cells.Cell("", typeof(CheckBox));
            grid1[1, 3] = new SourceGrid.Cells.Cell("", typeof(CheckBox));
            grid1[1, 4] = new SourceGrid.Cells.Cell("", typeof(CheckBox));
            grid1[1, 5] = new SourceGrid.Cells.Cell("", typeof(CheckBox));
            grid1[1, 6] = new SourceGrid.Cells.Cell("", typeof(CheckBox));
            grid1.AutoSizeCells();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
