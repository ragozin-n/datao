using OfficeOpenXml;
using System;
using System.Collections.Generic;

namespace ExcelManager
{
    public class CalendarWorkSheet
    {
        private ExcelWorksheet Core { get; set; }
        public List<Event> Calendar { get; private set; } = new List<Event>();

        public void AddEventToCalendar(Event _event)
        {
            Calendar.Add(_event);
        }

        /// <summary>
        /// Добавляет новое событие в календарь записей
        /// </summary>
        /// <param name="date">Дата события</param>
        /// <param name="startAt">Время начала</param>
        /// <param name="endAt">Время завершения</param>
        /// <param name="clientName">Имя клиента</param>
        /// <param name="serviceId">ID Услуги</param>
        /// <param name="workerId">ID Мастера</param>
        public void AddEventToCalendar(DateTime date, TimeSpan startAt, TimeSpan endAt, string clientName, uint serviceId, uint workerId)
        {
            Calendar.Add(new Event(date, startAt, endAt, clientName, serviceId, workerId));
        }

        //Можно дописать сортировку по дате, но таблица может и сама отсортировать

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        /// <param name="sheet">Лист "Календарь"</param>
        public CalendarWorkSheet(ExcelWorksheet sheet)
        {
            Core = sheet;

            //Обновляем лист событий
            var j = 1;
            while (Core.Cells[j, 0].Value != null)
            {
                try
                {
                    Event _event = new Event(
                        DateTime.Parse(Core.Cells[j, 1].Value.ToString()),
                        TimeSpan.Parse(Core.Cells[j, 2].Value.ToString()),
                        TimeSpan.Parse(Core.Cells[j, 3].Value.ToString()),
                        Core.Cells[j, 4].Value != null ? Core.Cells[j, 4].Value.ToString() : "Default",
                        uint.Parse(Core.Cells[j, 5].Value.ToString()),
                        uint.Parse(Core.Cells[j, 6].Value.ToString())
                        );

                    Calendar.Add(_event);
                    j++;
                }
                catch (Exception)
                {
                    //Возникла ошибка чтения строки
                    j++;
                }
            }
        }
    }
}
