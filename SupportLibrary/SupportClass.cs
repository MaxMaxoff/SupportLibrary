using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportLibrary
{
    public class SupportMethods
    {

        /// <summary>
        /// Input value and convert them from Str to Int
        /// repeat until value become integer and can be converted
        /// </summary>
        /// <param name="message">string incoming from programm</param>
        /// <returns>integer value number</returns>
        public static int RequestIntValue(string message)
        {
            int number;

            do
            { Console.WriteLine(message); }
            while (!Int32.TryParse(Console.ReadLine(), out number));

            return number;
        }

        /// <summary>
        /// Input value and convert them from Str to Int using Int32.Parse
        /// repeat until value become integer and can be converted
        /// In case of exception write exception message
        /// </summary>
        /// <param name="message">string incoming from programm</param>
        /// <returns>integer value number</returns>
        public static int RequestIntValueWithExceptionMsg(string message)
        {
            int number = 0;
            bool iserror = false;

            do
            {
                Console.WriteLine(message);
                try
                {
                    iserror = false;
                    number = Int32.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    iserror = true;
                    Console.WriteLine(e.Message);
                }
            }
            while (iserror);

            return number;
        }

        /// <summary>
        /// Input value and convert them from Str to Double
        /// repeat until value become double and can be converted
        /// </summary>
        /// <param name="message">string incoming from programm<</param>
        /// <returns>double value number</returns>
        public static double RequestDoubleValue(string message)
        {
            double number;

            do
            { Console.WriteLine(message); }
            while (!Double.TryParse(Console.ReadLine(), out number));

            return number;
        }

        /// <summary>
        /// Return string
        /// </summary>
        /// <param name="message">string incoming from programm</param>
        /// <returns></returns>
        public static string RequestString(string message)
        {
            string str;
            Console.WriteLine(message);
            str = Console.ReadLine();

            return str;
        }

        /// <summary>
        /// Just clear and change font color
        /// Also write message
        /// </summary>
        /// <param name="message">string incoming from programm</param>
        public static void PrepareConsoleForHomeTask(string message)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            
            Console.WriteLine(message);
        }

        /// <summary>
        /// Authentication method
        /// </summary>
        /// <param name="username">string incoming from programm</param>
        /// <param name="password">string incoming from programm</param>
        /// <param name="maxcount">Max attempts</param>
        /// <returns></returns>
        public static bool RequestUsernamePassword(string username, string password, int maxcount)
        {
            int count = 0;
            
            do
            {
                count++;

                if (username == RequestString("Please type your Username: ") || password == RequestString("Please type your password: "))
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

        public static void Print(string message, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(message);
        }
    }
}
