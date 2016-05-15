using System;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using ExcelManager;

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

            /*
            //Авторизация
            UserCredential _user = null;
            Authorization.FillCredentials(ref _user);
            bool? isOnline = Authorization.GetDataoInit(ref _user);
            */

            
            //Таблица
            Table.FillTable(new System.IO.FileInfo(@"..\..\datao.init.xlsx"));
            Event _event = new Event(
                DateTime.Now.Date,
                DateTime.Now.TimeOfDay,
                DateTime.Now.TimeOfDay,
                "Tester",
                555,
                345
                );
            Table.WorkList.AddEventToCalendar(_event);
            Table.WorkList.AddEventToCalendar(_event);
            Table.WorkList.AddEventToCalendar(_event);
            Table.Save();
            //Table.WorkList.RemoveEventFromCalendar("Tester");
            //Table.Save();

            /*

            //Должна принимать таблицу в любом формате
            switch (isOnline)
            {
                case true:
                    //С таблицей из диска
                    Application.Run(new AdminForm());
                    break;
                case false:
                    //С шаблоном
                    Application.Run(new AdminForm());
                    break;
                case null:
                    Environment.Exit(0);
                    break;
            }

            */
        }
    }
}
