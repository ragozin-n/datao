using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelManager
{
    public class PersonalWorkSheet
    {
        private ExcelWorksheet Core { get; set; }
        public List<Human> Schedule { get; private set; } = new List<Human>();
    }
}
