﻿using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace DATAO
{
    sealed class Authorization
    {

        public static UserCredential FillCredentials(ref UserCredential credential)
        {
            string[] scopes = { DriveService.Scope.Drive };

            using (var stream =
                new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = Environment.GetFolderPath(
                    Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, "datao/user");
                try
                {
                    credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    scopes,
                    "datao",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                    //Предполагается, что уже на этом шаге мы знаем, что пользователь в офлайне.
                    //Однако, скажем ему мы это на этапе загрузки таблицы.
                }
            }
            return credential;
        }

        public static bool? GetDataoInit(ref UserCredential credential)
        {
            FilesResource.ListRequest listRequest;
            DriveService service;
            IList<Google.Apis.Drive.v3.Data.File> files;
            try
            {
                //Создаем сервис запроса на гугл диск
                service = new DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "datao",
                });

                //Определяем параметры запроса
                listRequest = service.Files.List();
                listRequest.PageSize = 50;
                listRequest.Fields = "nextPageToken, files(id, name)";

                //Лист айдишников файлов
                files = listRequest.Execute()
                    .Files;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Offline mode");
                return false;
            }

            if (files != null && files.Count > 0)
            {
                foreach (var file in files)
                {
                    if (file.Name == "datao.init")
                    {
                        //Загружаем с драйва datao.init
                        var request = service.Files.Export(file.Id, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
                        var stream = new MemoryStream();
                        request.Download(stream);

                        //Сохраняем локально
                        byte[] a = stream.ToArray();
                        File.WriteAllBytes("datao.init.xlsx", a);

                        //MessageBox.Show("We are success downloaded datao.init file!\nPress OK to continue...");
                        return true;
                    }
                }
            }

            DialogResult dialogResult = MessageBox.Show("Do you want to use our template?\n(Also upload to Drive, if available)", "No datao.init file found!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //Процедура закачки
                var fileMetadata = new Google.Apis.Drive.v3.Data.File();
                fileMetadata.Name = "datao.init";
                fileMetadata.MimeType = "application/vnd.google-apps.spreadsheet";
                FilesResource.CreateMediaUpload _request;

                //TODO: Путь до локальной таблицы-шаблона
                using (var _stream = new FileStream("datao.init.xlsx",
                                        FileMode.Open))
                {
                    _request = service.Files.Create(
                        fileMetadata, _stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
                    _request.Fields = "id";
                    _request.Upload();
                }
                return false;
            }
            //Закрываем программу в случае отрицательного ответа
            return null;
        }
    }
}
