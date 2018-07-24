using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Библиотека необходимых методов для домашних работ
/// Методы добавляются по мере необходимости
/// </summary>
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

            Console.ForegroundColor = ConsoleColor.Red;
            do
            { Console.WriteLine(message); }
            while (!Int32.TryParse(Console.ReadLine(), out number));

            Console.ForegroundColor = ConsoleColor.Green;
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

            Console.ForegroundColor = ConsoleColor.Red;
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

            Console.ForegroundColor = ConsoleColor.Green;
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

            Console.ForegroundColor = ConsoleColor.Red;
            do
            { Console.WriteLine(message); }
            while (!Double.TryParse(Console.ReadLine(), out number));

            Console.ForegroundColor = ConsoleColor.Green;
            return number;
        }

        /// <summary>
        /// Return string
        /// </summary>
        /// <param name="message">string incoming from programm</param>
        /// <returns>string str</returns>
        public static string RequestString(string message)
        {
            string str;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            str = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            return str;
        }
        
        /// <summary>
        /// Return char
        /// </summary>
        /// <param name="message">string incoming from programm</param>
        /// <returns>char ch</returns>
        public static char RequestChar(string message)
        {
            char ch;
            string str;

            Console.ForegroundColor = ConsoleColor.Red;
            do
            {
                Console.WriteLine(message);
                str = Console.ReadLine();
                ch = str[0];
            }
            //uncomment next string if we are talking about symbols only not letters or digits
            //while (str.Length > 1 || !char.IsSymbol(ch));

            //comment this string if we are talking about symbols only not letters or digits
            while (str.Length > 1 || !char.IsLetterOrDigit(ch));
            
            Console.ForegroundColor = ConsoleColor.Green;
            return ch;
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

                if (username == RequestString("Please type your Username: ") && password == RequestString("Please type your password: "))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    return true;
                }
                                
                Console.WriteLine("Wrong username or password!");
                Console.WriteLine($"{maxcount - count} attempts remaining!");
            } while (count < maxcount);

            return false;
        }

        /// <summary>
        /// Get Fraction method
        /// </summary>
        /// <param name="numerator">outgoing integer</param>
        /// <param name="denominator">outgoing integer</param>
        /// <param name="message">string incoming from programm</param>
        public static void RequestFraction(out int numerator, out int denominator, string message)
        {
            denominator = 0;
            numerator = 0;
            bool denominatorBool = false;
            bool numeratorBool = false;

            Console.ForegroundColor = ConsoleColor.Red;
            do
            {
                Console.WriteLine(message);
                string str = Console.ReadLine();
                int indexOf = str.IndexOf("/");

                if (str.Length != 0 && indexOf != -1)
                {
                    string substring = str.Substring(0, indexOf);
                    numeratorBool = Int32.TryParse(substring, out numerator);

                    substring = str.Substring(indexOf + 1, str.Length - indexOf - 1);
                    denominatorBool = Int32.TryParse(substring, out denominator);
                }
            } while (numerator == 0 || denominator == 0 || !numeratorBool || !denominatorBool);

            Console.ForegroundColor = ConsoleColor.Green;
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

        public static void Print(string message, int x, int y, string color)
        {
            switch (color)
            {
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                default:
                    break;
            }
            Console.SetCursorPosition(x, y);
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Green;
        }

    }
}
