using System;
using System.Collections.Generic;
using OfficeOpenXml;
using System.Diagnostics;
using Organization;
using System.Linq;

namespace ExcelManager
{
    public class SalonWorkSheet
    {
        private ExcelWorksheet Core { get; set; }

        public SalonWorkSheet(ExcelWorksheet _core)
        {
            Core = _core;
            Enterprise.TimeTable.Clear();
            Enterprise.About.Fields.Clear();

            //Заполняем расписание
            for (int i = 2; i < 9; i++)
            {
                try
                {
                    string[] timeInterval = Core.Cells[1, i].Value.ToString().Split('-');
                    Enterprise.TimeTable.Add((Days)i - 1, new TimeSpan[] { TimeSpan.Parse(timeInterval[0]), TimeSpan.Parse(timeInterval[1]) });
                }
                catch (Exception ex) when (ex is FormatException || ex is NullReferenceException)
                {
                    Debug.WriteLine(ex.Message);
                }
            }

            //Заполняем имя
            Enterprise.About.Name = Core.Cells[3, 2].Value.ToString();

            //Заполняем остальные информационные поля
            int j = 4;
            while (Core.Cells[j,2].Value != null)
            {
                Enterprise.About.Fields.Add(Core.Cells[j, 1].Value.ToString(), Core.Cells[j, 2].Value.ToString());
            }
        }

        public void Update()
        {
            //Обновляем расписание
            for (int i = 2; i < 9; i++)
            {
                string timeInterval = $"{ Enterprise.TimeTable[(Days)i - 2][0].Hours}:{Enterprise.TimeTable[(Days)i - 2][0].Minutes} - { Enterprise.TimeTable[(Days)i - 2][1].Hours}:{Enterprise.TimeTable[(Days)i - 2][1].Minutes}";
                Core.Cells[2, i].Value = timeInterval;
            }

            //Обновляем имя
            Core.Cells[3, 2].Value = Enterprise.About.Name;

            //Обновляем дополнительные поля
            int j = 4;
            foreach (var key in Enterprise.About.Fields.Keys)
            {
                Core.Cells[j, 1].Value = key.ToString();
                Core.Cells[j, 2].Value = Enterprise.About.Fields[key];
                j++;
            }
        }
    }
}
