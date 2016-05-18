using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelManager
{
    public class StorehouseWorkSheet
    {
        private ExcelWorksheet Core { get; set; }
        public List<Item> ItemsList { get; private set; } = new List<Item>();

        public StorehouseWorkSheet(ExcelWorksheet _sheet)
        {
            Core = _sheet;
            ItemsList.Clear();

            int j = 2;
            while (Core.Cells[j, 1].Value != null)
            {
                try
                {
                    Dictionary<Item.Months, uint[]> balance = new Dictionary<Item.Months, uint[]>();
                    Item _item = new Item(
                        Core.Cells[j, 1].Value.ToString(),
                        Core.Cells[j, 2].Value.ToString(),
                        Core.Cells[j, 3].Value.ToString(),
                        uint.Parse(Core.Cells[j, 4].Value.ToString()),
                        uint.Parse(Core.Cells[j, 5].Value.ToString()),
                        balance
                        );
                    for (int i = 6; i < 18; i++)
                    {
                        var data = Core.Cells[j, i].Value.ToString().Split('/');
                        balance.Add((Item.Months)i - 6, new uint[]
                        {
                            uint.Parse(data[0]),
                            uint.Parse(data[1])
                        });
                    }
                    j++;
                }
                catch (Exception)
                {
                    //Ошибка
                    j++;
                }
            }
        }
    }
}
