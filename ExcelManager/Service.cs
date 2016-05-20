using System;

namespace ExcelManager
{
    public class Service
    {
        public uint ID { get; set; }
        public string Name { get; set;}
        public uint Cost { get; set; }
        //Дополнительные услуги просто как зарезервированное поле
        public uint AdditionalServiceID { get; set; }
        public TimeSpan Duration { get; set; }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        /// <param name="id">ID Услуги</param>
        /// <param name="name">Название услуги</param>
        /// <param name="cost">Цена</param>
        /// <param name="duration">Длительность</param>
        public Service(string name, uint cost, TimeSpan duration, uint id = 0)
        {
            if (id!= 0)
            {
                ID = id;
            }
            else
            {
                ID = (uint)GetHashCode();
            }
            Name = name;
            Cost = cost;
            Duration = duration;
        }
    }
}