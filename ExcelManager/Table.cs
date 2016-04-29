using OfficeOpenXml;
using System.IO;

namespace ExcelManager
{
    public class Table
    {
        public static void RenameCompany(FileInfo company, string name)
        {
            using (ExcelPackage xlPackage = new ExcelPackage(company))
            {
                xlPackage.Workbook.Worksheets["Салон"].Cells["C4"].Value = name;
                xlPackage.Save();
            }
        }

        public static void ChangeNumber(FileInfo company, string phone)
        {
            using (ExcelPackage xlPackage = new ExcelPackage(company))
            {
                xlPackage.Workbook.Worksheets["Салон"].Cells["B9"].Value = phone;
                xlPackage.Save();
            }
        }

        public static void ChangeSchedule(FileInfo company, string[] week)
        {
            //Пока что передается массив интервалов. В последующем здесь будет DateTime[]
            using (ExcelPackage xlPackage = new ExcelPackage(company))
            {
                for (int i = 1; i < week.Length+1; i++)
                {
                    xlPackage.Workbook.Worksheets["Салон"].Cells[2,i].Value = week[i-1];
                    xlPackage.Save();
                }
            }
        }
    }
}
