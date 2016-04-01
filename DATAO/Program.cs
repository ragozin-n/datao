using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.GData.Client;
using Google.GData.Spreadsheets;

namespace DATAO
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GAuthForm authF = new GAuthForm();            
            Application.Run(authF);
            AdminForm f = new AdminForm(authF.row);
            Application.Run(f);
        }
    }
}
