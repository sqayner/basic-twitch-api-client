using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_twitch_api_client
{
    class Program
    {
        static void Main(string[] args)
        {
            string consoleString;
            while (true)
            {
                consoleFirster();

                consoleString = Console.ReadLine().Replace("basic-twitch-api-client>", "");

                string[] consoleChars = consoleString.Split(new Char[] { ' ' });
                int consoleLength = consoleChars.Length;
                Console.WriteLine(consoleLength);

                switch (consoleLength)
                {
                    case 1:
                        switch (consoleString)
                        {
                            case "settings":
                                settings();
                                break;
                            default:
                                break;
                        }
                        break;
                    case 2:
                        switch (consoleString)
                        {
                            case "asd ":
                                Console.WriteLine("asddd");
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
                consoleString = "";
            }
        }

        private static void settings()
        {

        }

        private static void consoleWriteline(string response)
        {
            string firstText = "basic-twitch-api-client>";
            Console.WriteLine(firstText + response);
        }

        private static void consoleFirster()
        {
            string firstText = "basic-twitch-api-client>";
            Console.Write(firstText);
        }
    }
}
