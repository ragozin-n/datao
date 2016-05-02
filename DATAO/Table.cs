using OfficeOpenXml;
using System;
using System.IO;

namespace DATAO
{
    public sealed class Table
    {
        public static void Read(FileInfo input)
        {
            using (ExcelPackage xlPackage = new ExcelPackage(input))
            {
                ExcelWorksheet worksheet = xlPackage.Workbook.Worksheets[1];
            }
        }
    }


}
