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


            //Авторизация
            UserCredential _user = null;
            Authorization.FillCredentials(ref _user);
            bool? isOnline = Authorization.GetDataoInit(ref _user);

            //Таблица
            Table.FillTable(new System.IO.FileInfo(@"..\..\datao.init.xlsx"));
            //Отрисовка формы
            //Application.Run(new AdminForm());

            //Сохранее при закрытие формы и отправка на сервер
            Table.Save();
            Authorization.UploadDatao(ref _user);
        }
    }
}
