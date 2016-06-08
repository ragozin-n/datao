using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization
{
    public class Income
    {
        /// <summary>
        /// Дата прихода
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Непосредственно товар, который привезли
        /// </summary>
        public Goods Good { get; set; }

        /// <summary>
        /// Стоимость прихода
        /// </summary>
        public double Cost { get; set; }

        //Поставщика можно найти по адресу: Good.Provider
    }
}
