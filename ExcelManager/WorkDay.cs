﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelManager
{
    public class WorkDay
    {
        public TimeSpan Start { get; private set; }
        public TimeSpan End { get; private set; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dayTimeInterval">Интервал времени</param>
        /// <param name="separator">Необязательный параметр: разделитель ('-' по умолчанию)</param>
        public WorkDay(string dayTimeInterval, char separator = '-')
        {
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
                throw new ArgumentException();
            }
        }
    }
}
