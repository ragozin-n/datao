using OfficeOpenXml;
using Organization;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelManager
{
    public class PersonalWorkSheet
    {
        private ExcelWorksheet Core { get; set; }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        /// <param name="_sheet">Лист "Персонал"</param>
        public PersonalWorkSheet(ExcelWorksheet _sheet)
        {
            Core = _sheet;
            Enterprise.Personal.Clear();

            int j = 2;
            while (Core.Cells[j,1].Value != null)
            {
                Worker _worker = new Worker();
                _worker.About.Name = Core.Cells[j, 1].Value.ToString();

                //Заполнили свободные поля
                for (int i = 2; i < 5; i++)
                {
                    _worker.About.Fields.Add(Core.Cells[1, i].Value.ToString(), Core.Cells[j, i].Value.ToString());
                }

                //Заполнили расписание
                int k = 5;
                while (Core.Cells[j, k].Value != null)
                {
                    _worker.TimeTable.Data.Add(
                        DateTime.Parse(Core.Cells[1, k].Value.ToString()),
                        new Organization.WorkDay(Core.Cells[j, k].Value.ToString())
                        );
                    k++;
                }
                j++;
            }
        }
    }
}
