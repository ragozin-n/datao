using System;
using System.Collections.Generic;
using OfficeOpenXml;

namespace ExcelManager
{
    public class SalonWorkSheet
    {
        //Нужно проверить обновление таблицы. За это отвечает метод ExcelWorkbook.Save()
        private ExcelWorksheet Core { get; set; }
        public List<WorkDay> Schedule { get; private set; }
        public string Phone
        {
            get
            {
                return Core.Cells["B3"].Value.ToString();
            }
            set
            {
                Core.Cells["B3"].Value = value;
            }
        }
        //Я так думаю в ИНН могут быть и буквы, так что строка
        public string TIN
        {
            get
            {
                return Core.Cells["B4"].Value.ToString();
            }
            set
            {
                Core.Cells["B4"].Value = value;
            }
        }
        //Юридический адрес
        public string LegalAddress
        {
            get
            {
                return Core.Cells["B5"].Value.ToString();
            }
            set
            {
                Core.Cells["B5"].Value = value;
            }
        }
        //Фактический адрес
        public string ActualAddress
        {
            get
            {
                return Core.Cells["B6"].Value.ToString();
            }
            set
            {
                Core.Cells["B6"].Value = value;
            }
        }
        public uint AccountNumber
        {
            get
            {
                uint result;
                if(uint.TryParse(Core.Cells["B7"].Value.ToString(), out result))
                {
                    return result;
                } else
                {
                    throw new ArgumentException();
                }
            }
            set
            {
                uint result;
                if (uint.TryParse(value.ToString(), out result))
                {
                    Core.Cells["B7"].Value = value.ToString();
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        public string SalonName
        {
            get
            {
                return Core.Cells["B8"].Value.ToString();
            }
            set
            {
                Core.Cells["B8"].Value = value;
            }
        }

        /// <summary>
        /// Задает текущее расписание
        /// </summary>
        /// <param name="schedule">Массив дат через запятую в формате: 00:00 - 00:00</param>
        public void SetSchedule(string[] schedule)
        {
            Schedule = new List<WorkDay>();
            if (schedule.Length > 7)
            {
                throw new ArgumentOutOfRangeException();
            }

            //Задали свойство
            for (int i = 0; i < schedule.Length; i++)
            {
                Schedule.Add(new WorkDay(schedule[i]));
            }

            //Обновили таблицу
            for (int j = 1; j < Schedule.Count+1; j++)
            {
                Core.Cells[2, j+1].Value = $"{Schedule[j - 1].Start} - {Schedule[j - 1].End}";
            }
        }
        

            /// <summary>
            /// Конструктор по умолчанию
            /// </summary>
            /// <param name="sheet">Лист "Салон"</param>
        public SalonWorkSheet(ExcelWorksheet sheet)
        {
            Core = sheet;
            Schedule = new List<WorkDay>();

            //Обновили таблицу
            for (int j = 1; j < 8; j++)
            {
                if (Core.Cells[2, j+1].Value != null)
                {
                    Schedule.Add(new WorkDay(Core.Cells[2, j+1].Value.ToString()));
                }
                else { Schedule.Clear(); }
            }
        }
    }
}
