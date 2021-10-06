using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Google.Apis.PeopleService.v1;
using Google.Apis.PeopleService.v1.Data;

namespace CollegeSchedulingDesktopAppMain
{
    public class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        static string[] Scopes = { CalendarService.Scope.Calendar , PeopleServiceService.Scope.UserinfoProfile};
        static string ApplicationName = "CHC Meeting Scheduler";

        [STAThread]
        static void Main()
        { 
            UserCredential credential;

            using (var stream = new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)
                ).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            var service = new CalendarService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName
            });

            var service2 = new PeopleServiceService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName
            });

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain(service, service2));
        }
    }
}