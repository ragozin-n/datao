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

            var gAuth = new GAuthForm();
            Application.Run(gAuth);
            Application.Run(new AdminForm(gAuth.listFeed));
        }
    }
}
