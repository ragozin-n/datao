using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization
{
    /// <summary>
    /// Услуга предприятия
    /// </summary>
    public class Service
    {
        /// <summary>
        /// Информация о услуге
        /// </summary>
        public Info About { get; set; }

        /// <summary>
        /// Чистая стоимость услуги без учета стоимости расходных материалов
        /// </summary>
        private double ServiceCost { get; set; }

        /// <summary>
        /// Отвечает за выполнение услуги
        /// </summary>
        public bool isComplete { get; set; }

        /// <summary>
        /// Длительность услуги
        /// </summary>
        public TimeSpan Duration { get; set; }

        /// <summary>
        /// Расходы материалов за одну услугу
        /// </summary>
        private Dictionary<Goods, double> Expences { get; set; }

        /// <summary>
        /// Сумма ServiceCost и Expences
        /// </summary>
        public double Cost { get; set; }

        /// <summary>
        /// Дата записи услуги
        /// </summary>
        public DateTime RecordDate { get; set; }
    }
}
