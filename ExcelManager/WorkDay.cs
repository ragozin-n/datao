using System;

namespace ExcelManager
{
    public class WorkDay
    {
        public TimeSpan Start { get; private set; }
        public TimeSpan End { get; private set; }
        
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        /// <param name="dayTimeInterval">Интервал времени</param>
        /// <param name="separator">Необязательный параметр: разделитель ('-' по умолчанию)</param>
        public WorkDay(string dayTimeInterval, char separator = '-')
        {
            //Для создания нерабочих дней
            if (dayTimeInterval == string.Empty)
            {
                Start = TimeSpan.Parse("00:00:00");
                End = TimeSpan.Parse("00:00:00");
            }

            string[] timeInterval = new string[2];
            timeInterval = dayTimeInterval.Split(separator);

            DateTime _start,_end;
            if (DateTime.TryParse(timeInterval[0],out _start) && DateTime.TryParse(timeInterval[1], out _end))
            {
                Start = _start.TimeOfDay;
                End = _end.TimeOfDay;
            }
            else
            {
                throw new FormatException();
            }
        }
    }
}
