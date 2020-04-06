using System;
using System.Net;

namespace basic_twitch_api_client
{
    class Program
    {
        static WebClient webClient = new WebClient();
        static string client_id;
        static void Main(string[] args)
        {
            string consoleString;
            while (true)
            {
                Console.Title = "Basic Twitch Api Client";
                Console.Write("btac>");

                consoleString = Console.ReadLine().Replace("btac>", "");

                string[] consoleChars = consoleString.Split(new Char[] { ' ' });
                int consoleLength = consoleChars.Length;

                switch (consoleLength)
                {
                    case 1:
                        switch (consoleChars[0])
                        {
                            case "exit":
                                System.Environment.Exit(0);
                                break;
                            case "help":
                                help();
                                break;
                        }
                        break;
                    case 2:
                        if (client_id == null )
                        {
                            if (consoleChars[0] == "login")
                            {
                                login(consoleChars[1]);
                            }
                            else
                            {
                                Console.WriteLine("Please register your client ID by typing >login <YourClientId>");
                            }
                        }
                        else
                        {
                            switch (consoleChars[0])
                            {
                                case "getuserbyname":
                                    try
                                    {
                                        Console.WriteLine(webClient.DownloadString("https://api.twitch.tv/kraken/users?login=" + consoleChars[1] + "&api_version=5&client_id=" + client_id));
                                    }
                                    catch (WebException ex)
                                    {
                                        Console.WriteLine(ex.Message + "");
                                    }
                                    break;
                                case "getuserbyid":
                                    Console.WriteLine(webClient.DownloadString("https://api.twitch.tv/kraken/users?id=" + consoleChars[1] + "&api_version=5&client_id=" + client_id));
                                    break;
                            }
                        }
                        break;
                }
                consoleString = "";
            }
        }

        private static void login(string Lclientid)
        {
            if ((client_id = Lclientid) != "") { }
        }

        private static void help()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(@"           ____  _    _  ____  ____   ___  _   _ ");
            Console.WriteLine(@"          (_  _)( \/\/ )(_  _)(_  _) / __)( )_( )");
            Console.WriteLine(@"            )(   )    (  _)(_   )(  ( (__  ) _ ( ");
            Console.WriteLine(@"           (__) (__/\__)(____) (__)  \___)(_) (_)");
            Console.WriteLine(@"                     __    ____  ____            ");
            Console.WriteLine(@"                    /__\  (  _ \(_  _)           ");
            Console.WriteLine(@"                   /(__)\  )___/ _)(_            ");
            Console.WriteLine(@"                  (__)(__)(__)  (____)           ");
            Console.WriteLine(@"              ___  __    ____  ____  _  _  ____  ");
            Console.WriteLine(@"             / __)(  )  (_  _)( ___)( \( )(_  _) ");
            Console.WriteLine(@"            ( (__  )(__  _)(_  )__)  )  (   )(   ");
            Console.WriteLine(@"             \___)(____)(____)(____)(_)\_) (__)  ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("          Commands:");
            Console.WriteLine("             login <YourClientId>");
            Console.WriteLine("             exit");
            Console.WriteLine("             getuserbyname <userName,userName2,userName3... or only userName>");
            Console.WriteLine("             getuserbyid <userId,userId2,userId3... or only userId>");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void consoleWriteline(string response)
        {
            string firstText = "btac>";
            Console.WriteLine(firstText + response);
        }
    }
}
