using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelManager
{
    public class Human
    {
        public uint ID { get; private set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        //Отчество
        public string Patronymic { get; private set; }
        public string Status { get; private set; }
        public uint HoursWorked { get; private set; }
    }
}
