using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelManager
{
    public class StorehouseWorkSheet
    {
        private ExcelWorksheet Core { get; set; }
        public List<Item> ItemsList { get; private set; } = new List<Item>();

        public void AddItem(Item _item)
        {
            ItemsList.Add(_item);
            int j = 2;
            while (Core.Cells[j,1].Value != null)
            {
                j++;
            }
            Core.Cells[j, 1].Value = _item.CodeNumber;
            Core.Cells[j, 2].Value = _item.Name;
            Core.Cells[j, 3].Value = _item.Supplier;
            Core.Cells[j, 4].Value = _item.Cost;
            Core.Cells[j, 5].Value = _item.TotalResidue;
            for (int i = 6; i < 18; i++)
            {
                Core.Cells[j, i].Value = _item.Balance[(Item.Months)i - 6];
            }
        }

        public void RemoveItem(Item _item)
        {
            int j = 2;
            while (Core.Cells[j,1].Value != null)
            {
                //Артикул это как ID
                if (Core.Cells[j, 1].Value.ToString() == _item.CodeNumber.ToString())
                {
                    Core.DeleteRow(j);
                    ItemsList.Remove(_item);
                }
            }
        }

        public StorehouseWorkSheet(ExcelWorksheet _sheet)
        {
            Core = _sheet;

            int j = 2;
            while (Core.Cells[j, 1].Value != null)
            {
                Item _item = null;
                Dictionary<Item.Months, uint> balance = new Dictionary<Item.Months, uint>();
                try
                {
                    _item = new Item(
                        Core.Cells[j, 1].Value.ToString(),
                        Core.Cells[j, 2].Value.ToString(),
                        Core.Cells[j, 3].Value.ToString(),
                        uint.Parse(Core.Cells[j, 4].Value.ToString()),
                        uint.Parse(Core.Cells[j, 5].Value.ToString()),
                        balance
                        );
                }
                catch (Exception ex) when (ex is FormatException || ex is NullReferenceException)
                {
                    //Ошибка
                    Debug.WriteLine(ex.Message);
                    j++;
                }
                finally
                {
                    try
                    {
                        for (int i = 6; i < 18; i++)
                        {
                            balance.Add((Item.Months)i - 6, uint.Parse(Core.Cells[j, i].Value.ToString()));
                        }
                    }
                    catch (Exception ex) when (ex is FormatException || ex is NullReferenceException)
                    {
                        Debug.WriteLine(ex.Message);
                        //throw;
                        j++;
                    }
                    j++;
                }
            }
        }
    }
}
