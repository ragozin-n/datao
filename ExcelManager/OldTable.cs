using OfficeOpenXml;
using System.IO;

namespace ExcelManager
{
    public class OldTable
    {
        private static FileInfo dataoFileInfo { get; set; }
        private static ExcelPackage dataoPackage { get; set; }
        //Добавляю по мере написания листы
        public static SalonWorkSheet Salon { get; set; }
        public static CalendarWorkSheet WorkList { get; set; }
        public static PersonalWorkSheet PersonalList { get; set; }
        public static ServiceWorkSheet Services { get; set; }
        public static StorehouseWorkSheet Storehouse { get; set; }
        public static BalanceWorkSheet Expences { get; set; }
        public static BalanceWorkSheet Earnings { get; set; }


        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        /// <param name="pathToDataoInit">Путь до файла "datao.init"</param>
        public static void FillTable(FileInfo pathToDataoInit)
        {
            dataoFileInfo = pathToDataoInit;
            ExcelPackage xlPackage = new ExcelPackage(pathToDataoInit);
            //Сохраняем линк
            dataoPackage = xlPackage;
            //Добавлю по мере написания
            Salon = new SalonWorkSheet(xlPackage.Workbook.Worksheets["Салон"]);
            //PersonalList = new PersonalWorkSheet(xlPackage.Workbook.Worksheets["Персонал"]);
            //WorkList = new CalendarWorkSheet(xlPackage.Workbook.Worksheets["Календарь"]);
            //Services = new ServiceWorkSheet(xlPackage.Workbook.Worksheets["Услуги"]);
            //Storehouse = new StorehouseWorkSheet(xlPackage.Workbook.Worksheets["Склад"]);
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
            FillTable(dataoFileInfo);
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
