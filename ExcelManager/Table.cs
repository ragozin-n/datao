using OfficeOpenXml;
using System;
using System.IO;

namespace ExcelManager
{
    public class Table
    {
        private static FileInfo dataoFileInfo { get; set; }
        private static ExcelPackage dataoPackage { get; set; }
        //Добавляю по мере написания листы
        public static SalonWorkSheet Salon { get; set; }
        public static CalendarWorkSheet WorkList { get; set; }
        public static PersonalWorkSheet PersonalList { get; set; }
        public static ServiceWorkSheet Services { get; set; }
        public static StorehouseWorkSheet Storehouse { get; set; }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        /// <param name="pathToDataoInit">Путь до файла "datao.init"</param>
        public static void FillTable(FileInfo pathToDataoInit)
        {
            dataoFileInfo = pathToDataoInit;
            ExcelPackage xlPackage;
            try
            {
                xlPackage = new ExcelPackage(pathToDataoInit);
            }
            catch (NullReferenceException)
            {
                throw;
            }
            //Сохраняем линк
            dataoPackage = xlPackage;

            Salon = new SalonWorkSheet(xlPackage.Workbook.Worksheets["Салон"]);
            PersonalList = new PersonalWorkSheet(xlPackage.Workbook.Worksheets["Персонал"]);
            Services = new ServiceWorkSheet(xlPackage.Workbook.Worksheets["Услуги"]);
            WorkList = new CalendarWorkSheet(xlPackage.Workbook.Worksheets["Календарь"]);
            Storehouse = new StorehouseWorkSheet(xlPackage.Workbook.Worksheets["Склад"]);
            
            ////Расходы
            //Expences = new BalanceWorkSheet(xlPackage.Workbook.Worksheets["Расходы"]);
            ////Доходы
            //Earnings = new BalanceWorkSheet(xlPackage.Workbook.Worksheets["Доходы"]);
        }


        /// <summary>
        /// Обновляет текущее состояние таблицы
        /// </summary>
        public static void Update()
        {
            //Пишем в файл
            Salon.Update();
            PersonalList.Update();
            Services.Update();
            WorkList.Update();
            Storehouse.Update();
        }

        /// <summary>
        /// Сохраняет текущее состояние таблицы
        /// </summary>
        public static void Save()
        {
            dataoPackage.Save();
            var _file = new FileStream(dataoFileInfo.ToString(), FileMode.Open);
            dataoPackage.Load(_file);
            _file.Close();
        }
    }
}
