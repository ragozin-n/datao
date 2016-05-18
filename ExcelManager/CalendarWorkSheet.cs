using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExcelManager
{
    public class CalendarWorkSheet
    {
        private ExcelWorksheet Core { get; set; }
        public List<Event> Calendar { get; private set; } = new List<Event>();

        /// <summary>
        /// Добавляет новое событие в календарь записей
        /// </summary>
        /// <param name="_event">Текущее событие</param>
        public void AddEventToCalendar(Event _event)
        {
            Calendar.Add(_event);
            int j = 2;
            while (Core.Cells[j, 1].Value != null)
            {
                j++;
            }
            Core.Cells[j, 1].Style.Numberformat.Format = "dd/mm/yy";
            Core.Cells[j, 1].Formula = $"DATE({_event.Date.Year},{_event.Date.Month},{_event.Date.Day})";
            Core.Cells[j, 1].Calculate();

            Core.Cells[j, 2].Style.Numberformat.Format = "hh:mm";
            Core.Cells[j, 2].Formula = $"TIME({_event.StartAt.Hours},{_event.StartAt.Minutes},{_event.StartAt.Seconds})";
            Core.Cells[j, 2].Calculate();

            Core.Cells[j, 3].Style.Numberformat.Format = "hh:mm";
            Core.Cells[j, 3].Formula = $"TIME({_event.EndAt.Hours},{_event.EndAt.Minutes},{_event.EndAt.Seconds})";
            Core.Cells[j, 3].Calculate();

            Core.Cells[j, 4].Value = _event.ClientName;
            Core.Cells[j, 5].Value = _event.ServiceID;
            Core.Cells[j, 6].Value = _event.WorkerID;
        }

        /// <summary>
        /// Удаляет событие из календаря
        /// </summary>
        /// <param name="_event">Текущее событие</param>
        public void RemoveEventFromCalendar(Event _event)
        {
            int j = 2;
            while (Core.Cells[j, 1].Value != null)
            {
                if (Core.Cells[j, 1].Value.ToString() == _event.Date.ToString())
                {
                    if (Core.Cells[j, 2].Value.ToString() == _event.StartAt.ToString())
                    {
                        if (Core.Cells[j, 3].Value.ToString() == _event.EndAt.ToString())
                        {
                            if (Core.Cells[j, 4].Value.ToString() == _event.ClientName.ToString())
                            {
                                if (Core.Cells[j, 5].Value.ToString() == _event.ServiceID.ToString())
                                {
                                    if (Core.Cells[j, 6].Value.ToString() == _event.WorkerID.ToString())
                                    {
                                        Core.DeleteRow(j);
                                        Calendar.Remove(_event);
                                    }
                                }
                            }
                        }
                    }
                }
                j++;
            }
        }

        /// <summary>
        /// Удаляет событие из календаря
        /// </summary>
        /// <param name="row">Номер ряда, который нужно удалить</param>
        public void RemoveEventFromCalendar(int row)
        {
            //Не нужно
            //Event _event = new Event(
            //        DateTime.FromOADate(long.Parse(Core.Cells[row, 1].Value.ToString())).Date,
            //        TimeSpan.FromHours(double.Parse(Core.Cells[row, 2].Value.ToString())),
            //        TimeSpan.FromHours(double.Parse(Core.Cells[row, 3].Value.ToString())),
            //        Core.Cells[row, 4].Value.ToString(),
            //        uint.Parse(Core.Cells[row, 5].Value.ToString()),
            //        uint.Parse(Core.Cells[row, 6].Value.ToString())
            //        );
            //Calendar.Remove(_event);
            //Core.DeleteRow(row);
        }

        /// <summary>
        /// Удаляет соыбтие из календаря
        /// </summary>
        /// <param name="date">Дата событий для удаления</param>
        public void RemoveEventFromCalendar(DateTime date)
        {
            int j = 2;
            while (Core.Cells[j, 1].Value != null)
            {
                if (Core.Cells[j, 1].Value.ToString() == date.ToString())
                {
                    var _event = Calendar.First(_e => _e.Date == date);
                    Calendar.Remove(_event);
                    Core.DeleteRow(j);
                }
                j++;
            }
        }

        /// <summary>
        /// Удаляет событие из календаря
        /// </summary>
        /// <param name="workerID">ID рабочего</param>
        public void RemoveEventFromCalendar(uint workerID, uint serviceId = 0)
        {
            //Это хитрый метод для удаления только событий данного рабочего!
            //Так как нельзя определить два void метода с параметрами uint
            //Здесь используется serviceID, который можно задавать как угодно, по умолчанию он 0

            //Не нужен ваще по-моему
            //int j = 2;
            //while (Core.Cells[j, 1].Value != null)
            //{
            //    if (Core.Cells[j, 6].Value.ToString() == workerID.ToString())
            //    {
            //        Event _event = new Event(
            //        DateTime.FromOADate(long.Parse(Core.Cells[j, 1].Value.ToString())).Date,
            //        TimeSpan.FromHours(double.Parse(Core.Cells[j, 2].Value.ToString())),
            //        TimeSpan.FromHours(double.Parse(Core.Cells[j, 3].Value.ToString())),
            //        Core.Cells[j, 4].Value.ToString(),
            //        uint.Parse(Core.Cells[j, 5].Value.ToString()),
            //        uint.Parse(Core.Cells[j, 6].Value.ToString())
            //        );

            //        Calendar.Remove(_event);
            //        Core.DeleteRow(j);
            //    }
            //    j++;
            //}
        }

        /// <summary>
        /// Удаляет событие из календаря
        /// </summary>
        /// <param name="serviceID">ID услуги</param>
        public void RemoveEventFromCalendar(uint serviceID)
        {
            int j = 2;
            while (Core.Cells[j, 1].Value != null)
            {
                if (Core.Cells[j, 5].Value.ToString() == serviceID.ToString())
                {
                    //Первое вхождение
                    var _event = Calendar.First(_e => _e.ServiceID == serviceID);
                    Calendar.Remove(_event);
                    Core.DeleteRow(j);
                }
                j++;
            }
        }

        /// <summary>
        /// Удаляет событие из календаря
        /// </summary>
        /// <param name="clientName">Имя клиента</param>
        public void RemoveEventFromCalendar(string clientName)
        {
            int j = 2;
            while (Core.Cells[j, 1].Value != null)
            {
                if (Core.Cells[j, 4].Value.ToString() == clientName)
                {
                    //Первое вхождение
                    var _event = Calendar.First(_e => _e.ClientName == clientName);
                    Calendar.Remove(_event);
                    Core.DeleteRow(j);
                }
                j++;
            }
        }

        /// <summary>
        /// Удаляет событие из календаря
        /// </summary>
        /// <param name="date">Дата</param>
        /// <param name="startAt">Время начала</param>
        /// <param name="workerID">ID мастера</param>
        public void RemoveEventFromCalendar(DateTime date, TimeSpan startAt, uint workerID)
        {
            int j = 2;
            while (Core.Cells[j, 1].Value != null)
            {
                if (DateTime.Parse(Core.Cells[j, 1].Value.ToString()).ToString() == date.ToString())
                {
                    if (TimeSpan.Parse(Core.Cells[j, 2].Value.ToString()).ToString() == startAt.ToString())
                    {
                        if (Core.Cells[j, 6].Value.ToString() == workerID.ToString())
                        {
                            var _event = Calendar.First(_e => (_e.Date == date && _e.StartAt == startAt && _e.WorkerID == workerID));
                            Calendar.Remove(_event);
                            Core.DeleteRow(j);
                        }
                    }
                }
                j++;
            }
        }
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
                try
                {
                    Event _event = new Event(
                        DateTime.Parse(Core.Cells[j, 1].Value.ToString()),
                        TimeSpan.Parse(Core.Cells[j, 2].Value.ToString()),
                        TimeSpan.Parse(Core.Cells[j, 3].Value.ToString()),
                        Core.Cells[j, 4].Value.ToString(),
                        uint.Parse(Core.Cells[j, 6].Value.ToString()),
                        uint.Parse(Core.Cells[j, 5].Value.ToString())
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
