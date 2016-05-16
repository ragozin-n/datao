using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelManager
{
    public class PersonalWorkSheet
    {
        private ExcelWorksheet Core { get; set; }
        public List<Human> Workers { get; private set; } = new List<Human>();

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        /// <param name="_sheet">Лист "Персонал"</param>
        public PersonalWorkSheet(ExcelWorksheet _sheet)
        {
            Core = _sheet;
            Workers.Clear();
            int j = 2;
            while (Core.Cells[j, 1].Value != null)
            {
                try
                {
                    List<bool> _schedule = new List<bool>();
                    for (int i = 0; i < 7; i++)
                    {
                        _schedule.Add(bool.Parse(Core.Cells[j, 8 + i].Value.ToString()));
                    }
                    Workers.Add(new Human(
                        uint.Parse(Core.Cells[j, 1].Value.ToString()),
                        Core.Cells[j, 2].Value.ToString(),
                        Core.Cells[j, 3].Value.ToString(),
                        Core.Cells[j, 4].Value.ToString(),
                        Core.Cells[j, 5].Value.ToString(),
                        uint.Parse(Core.Cells[j, 6].Value.ToString()),
                        Core.Cells[j, 7].Value.ToString(),
                        Core.Cells[j, 15].Value.ToString(),
                        Core.Cells[j, 16].Value.ToString(),
                        _schedule.ToArray()
                        ));
                    j++;
                }
                catch (Exception)
                {
                    j++;
                }
            }
        }

        /// <summary>
        /// Добавляет рабочего в список
        /// </summary>
        /// <param name="_human">Рабочий</param>
        public void AddWorker(Human _human)
        {
            Workers.Add(_human);

            int j = 2;
            while (Core.Cells[j, 1].Value != null)
            {
                j++;
            }
            Core.Cells[j, 1].Value = _human.ID;
            Core.Cells[j, 2].Value = _human.Surname;
            Core.Cells[j, 3].Value = _human.Name;
            Core.Cells[j, 4].Value = _human.Patronymic;
            Core.Cells[j, 5].Value = _human.Status;
            Core.Cells[j, 6].Value = _human.HoursWorked;
            Core.Cells[j, 7].Value = _human.Rate;
            for (int i = 8; i < 15; i++)
            {
                Core.Cells[j, i].Value = _human.Schedule[i - 8];
            }
            Core.Cells[j, 15].Value = _human.Tel;
            Core.Cells[j, 16].Value = _human.Addres;
        }

        /// <summary>
        /// Удаляет заданного рабочего
        /// </summary>
        /// <param name="_workerId">ID рабочего</param>
        public void RemoveWorker(uint _workerId)
        {
            int j = 2;
            while (Core.Cells[j, 1].Value != null)
            {
                if (Core.Cells[j,1].Value.ToString() == _workerId.ToString())
                {
                    Core.DeleteRow(j);
                    Workers.Remove(Workers.First(w => w.ID == _workerId));
                }
            }
        }
    }
}
