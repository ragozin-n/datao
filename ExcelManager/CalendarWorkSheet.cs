using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using Organization;
using System.Diagnostics;

namespace ExcelManager
{
    public class CalendarWorkSheet
    {
        private ExcelWorksheet Core { get; set; }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        /// <param name="sheet">Лист "Календарь"</param>
        public CalendarWorkSheet(ExcelWorksheet sheet)
        {
            Core = sheet;

            //Обновляем лист событий
            int j = 2;
            //Удивительно, но первая ячейка в таблице это 1,1
            while (Core.Cells[j, 1].Value != null)
            {
                Worker _master = null;
                try
                {
                    _master = Enterprise.Personal.First(worker => worker.About.Name == Core.Cells[j, 6].Value.ToString());
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    //Нет такого рабочего или он не работает в этот день
                    throw;
                }
            }
        }
    }
}
