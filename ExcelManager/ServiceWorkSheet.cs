using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelManager
{
    public class ServiceWorkSheet
    {
        private ExcelWorksheet Core { get; set; }
        public List<Service> ServiceList { get; private set; } = new List<Service>();
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        /// <param name="_sheet">Лист "Услуги"</param>
        public ServiceWorkSheet(ExcelWorksheet _sheet)
        {
            Core = _sheet;
            ServiceList.Clear();
            int j = 2;
            while (Core.Cells[j, 1].Value != null)
            {
                try
                {
                    Service _service = new Service(
                        Core.Cells[j, 2].Value.ToString(),
                        uint.Parse(Core.Cells[j, 3].Value.ToString()),
                        DateTime.Parse(Core.Cells[j, 5].Value.ToString()).TimeOfDay,
                        uint.Parse(Core.Cells[j, 1].Value.ToString())
                        );
                    ServiceList.Add(_service);
                    j++;
                }
                catch (Exception)
                {
                    //Ошибка
                    j++;
                }
            }
        }

        /// <summary>
        /// Добавляет услугу в перечень услуг
        /// </summary>
        /// <param name="_service">Услуга</param>
        public void AddNewService(Service _service)
        {
            ServiceList.Add(_service);
            int j = 2;
            while (Core.Cells[j, 1].Value != null)
            {
                j++;
            }
            Core.Cells[j, 1].Value = _service.ID;
            Core.Cells[j, 2].Value = _service.Name;
            Core.Cells[j, 3].Value = _service.Cost;
            Core.Cells[j, 4].Value = _service.AdditionalServiceID;

            Core.Cells[j, 5].Style.Numberformat.Format = "hh:mm";
            Core.Cells[j, 5].Formula = $"TIME({_service.Duration.Hours},{_service.Duration.Minutes},{_service.Duration.Seconds})";
            Core.Cells[j, 5].Calculate();
        }
        /// <summary>
        /// Удаляет заданную услугу из перечня услуг
        /// </summary>
        /// <param name="ID">ID услуги</param>
        public void RemoveService(Service _service)
        {
            int j = 2;
            while (Core.Cells[j, 1].Value != null)
            {
                if (Core.Cells[j,1].Value.ToString() == _service.ID.ToString())
                {
                    ServiceList.Remove(_service);
                    Core.DeleteRow(j);
                    j++;
                }
                j++;
            }
        }
    }
}
