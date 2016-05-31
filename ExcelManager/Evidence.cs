using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelManager
{
    public class Evidence
    {
        //Пишем вот так: -150, поэтому инт
        public Dictionary<Item.Months, int> Budget { get; private set; } = new Dictionary<Item.Months, int>
        {
            //Остаток, израсходовано
            [Item.Months.January] = 0,
            [Item.Months.February] = 0,
            [Item.Months.March] = 0,
            [Item.Months.April] = 0,
            [Item.Months.June] = 0,
            [Item.Months.July] = 0,
            [Item.Months.August] = 0,
            [Item.Months.September] = 0,
            [Item.Months.October] = 0,
            [Item.Months.November] = 0,
            [Item.Months.December] = 0
        };

        public string Name { get; private set; }

        public Evidence(string name, Dictionary<Item.Months,int> budget)
        {
            Name = name;
            Budget = budget;
        }
        public void UpdateEvidence(string name)
        {
            Name = name;
        }

        public void UpdateEvidence(Item.Months _months, int _value)
        {
            Budget[_months] = _value;
        }

        public void UpdateEvidence(Dictionary<Item.Months,int> _budget)
        {
            Budget = _budget;
        }
    }
}
