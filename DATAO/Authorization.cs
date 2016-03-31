using Google.GData.Client;
using Google.GData.Spreadsheets;

namespace DATAO
{
    sealed class Authorization
    {
        public static string CreatAauthorizationLink(OAuth2Parameters parameters)
        {
            parameters.ClientId = "144023824946-13eih1nnnlh8oq9ae8lmdaamchj8bc69.apps.googleusercontent.com";
            parameters.ClientSecret = "96MURyKXl8uApYvdn6fWO_3T";
            parameters.RedirectUri = "urn:ietf:wg:oauth:2.0:oob:auto";
            parameters.Scope = "https://spreadsheets.google.com/feeds https://docs.google.com/feeds";

            return OAuthUtil.CreateOAuth2AuthorizationUrl(parameters);
        }

        public static ListFeed GetTablesFeed(OAuth2Parameters parameters, string accessCode)
        {
            try
            {
                parameters.AccessCode = accessCode;
                OAuthUtil.GetAccessToken(parameters);

                GOAuth2RequestFactory requestFactory =
                    new GOAuth2RequestFactory(null, "DATAO", parameters);

                SpreadsheetsService service = new SpreadsheetsService("DATAO");
                service.RequestFactory = requestFactory;

                SpreadsheetQuery query = new SpreadsheetQuery();
                SpreadsheetFeed feed = service.Query(query);

                //Ищем таблицу с именем datao.init
                //Ее в последствии положим в spreadsheet
                SpreadsheetEntry spreadsheet = new SpreadsheetEntry();
                foreach (SpreadsheetEntry entry in feed.Entries)
                {
                    if (entry.Title.Text == "datao.init")
                    {
                        spreadsheet = entry;
                    }
                }

                //Разбиваем полученную таблицу на листы
                WorksheetFeed wsFeed = spreadsheet.Worksheets;

                //Берем первый лист, там содержится ID, Имя, Фамилия и Дата регистрации
                WorksheetEntry worksheet = (WorksheetEntry)wsFeed.Entries[0];

                //Стандартная операция запроса сетки таблицы от Google
                AtomLink listFeedLink = worksheet.Links.FindService(GDataSpreadsheetsNameTable.ListRel, null);
                ListQuery listQuery = new ListQuery(listFeedLink.HRef.ToString());
                ListFeed listFeed = service.Query(listQuery);

                return listFeed;
            }
            catch (System.Exception)
            {
                //
                return null;
            }
        }
    }
}
