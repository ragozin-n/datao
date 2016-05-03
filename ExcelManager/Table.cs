using OfficeOpenXml;
using System.IO;

namespace ExcelManager
{
    public class Table
    {
        private static ExcelPackage linkToDatao { get; set; }
        //Добавляю по мере написания листы
        public static SalonWorkSheet Salon { get; set; }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        /// <param name="pathToDataoInit">Путь до файла "datao.init"</param>
        public static void FillTable(FileInfo pathToDataoInit)
        {
            ExcelPackage xlPackage = new ExcelPackage(pathToDataoInit);
            //Сохраняем линк
            linkToDatao = xlPackage;
            //Добавлю по мере написания
            Salon = new SalonWorkSheet(xlPackage.Workbook.Worksheets["Салон"]);

            //Тут может течь память, в дальнейшем разберемся
            //xlPackage.Dispose();
        }
        public static void Save()
        {
            var oldPackage = linkToDatao;
            linkToDatao.Save();
            linkToDatao = oldPackage;
        }
    }
}
