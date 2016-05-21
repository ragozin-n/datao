using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization
{
    /// <summary>
    /// Рабочий предприятия
    /// </summary>
    public class Worker : Human
    {
        /// <summary>
        /// Расписание рабочего
        /// </summary>
        public Schedule TimeTable { get; set; }

        /// <summary>
        /// Ставка рабочего (в день/месяц/час нужно выбрать)
        /// </summary>
        public double WageRate { get; set; }
    }
}
