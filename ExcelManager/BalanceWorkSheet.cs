using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelManager
{
    public class BalanceWorkSheet
    {
        private ExcelWorksheet Core { get; set; }

        public List<Evidence> Balance = new List<Evidence>();

        public BalanceWorkSheet(ExcelWorksheet _sheet)
        {
            Core = _sheet;
            //Не обязательно
            Balance.Clear();
            int j = 2;
            while (Core.Cells[1,j].Value != null)
            {
                Dictionary<Item.Months, int> _balance = new Dictionary<Item.Months, int>();
                for (int i = 2; i < 14; i++)
                {
                    _balance.Add((Item.Months)i - 2, int.Parse(Core.Cells[i, j].Value.ToString()));
                }
                Evidence _consumable = new Evidence(Core.Cells[1, j].Value.ToString(), _balance);
                Balance.Add(_consumable);
            }
        }

        public void AddConsumable(Evidence _evidence)
        {
            Balance.Add(_evidence);
            int j = 2;
            while (Core.Cells[1,j].Value != null)
            {
                j++;
            }

            Core.Cells[1, j].Value = _evidence.Name;

            for (int i = 2; i < 14; i++)
            {
                Core.Cells[i, j].Value = _evidence.Budget[(Item.Months)i - 2];
            }
        }

        public void RemoveEvidence(Evidence _evidence)
        {
            int j = 2;
            while (Core.Cells[1,j].Value != null)
            {
                if (Core.Cells[1,j].Value.ToString() == _evidence.Name)
                {
                    Core.DeleteColumn(j);
                    Balance.Remove(_evidence);
                }
            }
        }
    }
}
