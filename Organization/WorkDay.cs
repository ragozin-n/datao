using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization
{
    /// <summary>
    /// Рабочий день мастера
    /// </summary>
    public class WorkDay
    {
        /// <summary>
        /// Дата рабочего дня
        /// </summary>
        public DateTime Start { get; set; }

        /// <summary>
        /// Длительность рабочего дня
        /// </summary>
        public TimeSpan Duration { get; set; }

        /// <summary>
        /// Все записи мастера за текущий день
        /// </summary>
        public Dictionary<DateTime, Event> Events { get; set; }
    }
}
