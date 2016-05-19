using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelManager
{
    public class Item
    {
        //Артикул
        public string CodeNumber { get; private set; }
        public string Name { get; private set; }
        public string Supplier { get; private set; }
        public uint Cost { get; private set; }
        
        //Общий остаток
        public uint TotalResidue { get; private set; }

        public Dictionary<Months, uint> Balance { get; set; } = new Dictionary<Months, uint>
        {
            //Остаток, израсходовано
            [Months.January] = 0,
            [Months.February] = 0,
            [Months.March] = 0,
            [Months.April] = 0,
            [Months.June] = 0,
            [Months.July] = 0,
            [Months.August] = 0,
            [Months.September] = 0,
            [Months.October] = 0,
            [Months.November] = 0,
            [Months.December] = 0
        };

        public enum Months
        {
            January = 1,
            February, March, April, May, June, July, August, September, October, November, December
        }

        public Item(string codeNumber, string name, string supplier, uint cost, uint total, Dictionary<Months,uint> balance)
        {
            CodeNumber = codeNumber;
            Name = name;
            Supplier = supplier;
            Cost = cost;
            TotalResidue = total;
            if (balance.Count != 12)
            {
                throw new ArgumentOutOfRangeException();
            }
            Balance = balance;
        }

        public void UpdateItem(string codeNumber)
        {
            CodeNumber = codeNumber;
        }
        public void UpdateItem(string name, string supplier)
        {
            Name = name;
            Supplier = supplier;
        }
        public void UpdateItem(string codeNumber, string name, string supplier)
        {
            UpdateItem(codeNumber);
            UpdateItem(name, supplier);
        }
        public void UpdateItem(uint cost, uint total)
        {
            Cost = cost;
            TotalResidue = total;
        }
        public void UpdateItem(uint total)
        {
            TotalResidue = total;
        }
        public void UpdateItem(Dictionary<Months,uint> balance)
        {
            if (balance.Count != 12)
            {
                throw new ArgumentOutOfRangeException();
            }
            Balance = balance;
        }
    }
}
