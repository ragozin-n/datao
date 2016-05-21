using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization
{
    /// <summary>
    /// Предприятие, которое оказывает услуги, имеет рабочих и клиентов, а также
    /// свой собственный склад и расписание своей работы.
    /// </summary>
    public class Organization
    {
        /// <summary>
        /// Информация о предприятии
        /// </summary>
        public Info About { get; set; }

        /// <summary>
        /// Расписание предприятие в формате:
        /// 1. Дата рабочего дня
        /// 2. Количество часов работы
        /// </summary>
        public Dictionary<DateTime, TimeSpan> TimeTable { get; set; }

        /// <summary>
        /// Персонал предприятия
        /// </summary>
        public List<Worker> Personal { get; set; }

        /// <summary>
        /// Перечень услуг предприятия
        /// </summary>
        public List<Service> PriceList { get; set; }

        /// <summary>
        /// Склад предприятия
        /// </summary>
        public Dictionary<Goods,Dictionary<Months,uint>> WareHouse { get; set; }

        /// <summary>
        /// Клиенты (постоянные или не очень) предприятия
        /// </summary>
        public List<Client> Clients { get; set; }
    }
}
