using System;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
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

            //Авторизация
            UserCredential _user = null;
            Authorization.FillCredentials(ref _user);
            bool? isOnline = Authorization.GetDataoInit(ref _user);

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
        }
    }
}
