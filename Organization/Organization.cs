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
    public static class Enterprise
    {
        /// <summary>
        /// Информация о предприятии
        /// </summary>
        public static Info About { get; set; } = new Info();

        /// <summary>
        /// Расписание предприятие в формате:
        /// 1. Дата рабочего дня
        /// 2. Количество часов работы
        /// </summary>
        public static Dictionary<Days, TimeSpan[]> TimeTable { get; set; } = new Dictionary<Days, TimeSpan[]>(7);

        /// <summary>
        /// Персонал предприятия
        /// </summary>
        public static List<Worker> Personal { get; set; }

        /// <summary>
        /// Перечень услуг предприятия
        /// </summary>
        public static List<Service> PriceList { get; set; }

        /// <summary>
        /// Склад предприятия
        /// </summary>
        public static Dictionary<Goods,Dictionary<Months,uint>> WareHouse { get; set; }

        /// <summary>
        /// Клиенты (постоянные или не очень) предприятия
        /// </summary>
        public static List<Client> Clients { get; set; }
    }
}
