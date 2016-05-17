using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelManager
{
    public class Human
    {
        public uint ID { get; private set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        //Отчество
        public string Patronymic { get; private set; }
        public string Status { get; private set; }
        public uint HoursWorked { get; private set; }
        public string Rate { get; private set; }
        public bool[] Schedule { get; private set; } = new bool[7] { true, true, true, true , true, true, false};
        public string Tel { get; private set; }
        public string Addres { get; private set; }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        /// <param name="id">ID работника</param>
        /// <param name="name">Имя</param>
        /// <param name="surname">Фамилия</param>
        /// <param name="patronymic">Отчество</param>
        /// <param name="status">Статус</param>
        /// <param name="hoursWorked">Отработанные часы</param>
        /// <param name="rate">Ставка</param>
        /// <param name="tel">Контактный телефон</param>
        /// <param name="addres">Адрес проживания</param>
        /// <param name="schedule">Расписание</param>
        public Human(string name, string surname, 
                     string patronymic, string status, uint hoursWorked, 
                     string rate, string tel, string addres, bool[] schedule, uint id = 0)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Status = status;
            HoursWorked = hoursWorked;
            Rate = rate;
            Tel = tel;
            Addres = addres;
            Schedule = schedule;
            if (id != 0)
            {
                ID = (uint)GetHashCode();
            }
            else
            {
                ID = id;
            }
        }

    }
}
