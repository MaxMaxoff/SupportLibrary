using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportLibrary
{
    public class SupportMethods
    {
        public static void Print(string message, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(message);
        }

        public static int RequestIntValue(string message)
        {
            int number = 0;

            //Input value and convert them from Str to Int
            //repeat until value become integer and can be converted
            do
            { Console.WriteLine(message); }
            while (!Int32.TryParse(Console.ReadLine(), out number));

            return number;
        }

        public static double RequestDoubleValue(string message)
        {
            double number;

            //Input value and convert them from Str to Double
            //repeat until value become double and can be converted
            do
            { Console.WriteLine(message); }
            while (!Double.TryParse(Console.ReadLine(), out number));

            return number;
        }

        public static void PrepareConsoleForHomeTask(string message)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
        }

        public static bool RequestUsernamePassword(string username, string password)
        {
            int count = 0;
            const int maxcount = 3;
            string uname;
            string pwd;
            
            do
            {
                count++;

                Console.Write("Please type your Username: ");
                uname = Console.ReadLine();

                Console.Write("Please type your password: ");
                pwd = Console.ReadLine();

                if (username == uname || password == pwd)
                {
                    return true;
                }
                                
                Console.WriteLine("Wrong username or password!");
                Console.WriteLine($"{maxcount - count} attempts remaining!");
            } while (count < maxcount);

            Console.WriteLine("Authentication filed!");
            return false;
        }
            
        public static void Pause()
        {
            Console.ReadKey();
        }

        public static void Pause(string message)
        {
            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
