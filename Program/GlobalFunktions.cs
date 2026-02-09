using System;

namespace GlobalFunktion.Kit
{
    /// <summary>
    /// Small things that are used evreywhere in the project. Like the users inputs
    /// </summary>
    public abstract class GlobalFunktionKitClass
    {
        /// <summary>
        /// Makes the user type a string that will be returned if valid. Also asks a quastion with the prama.
        /// </summary>
        /// <returns>A string</returns>
        public static string TypeString(string qusation = null)
        {
            string input = "";
            while (true)
            {
                if (qusation == null) { Console.WriteLine("Type a string!"); }
                else { Console.WriteLine(qusation); }
                input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                {
                    return input;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    Console.ReadLine();
                }
            }
        }
        /// <summary>
        /// Makes the user type a number that will be returned if valid. Also asks a quastion with the prama.
        /// </summary>
        /// <returns>A int</returns>
        public static int TypeInt(string qusation = null, int min = 0, int max = 0)
        {
            string input = "";
            int number;
            while (true)
            {
                if (qusation == null) { Console.WriteLine("Type a number!"); }
                else { Console.WriteLine(qusation); }
                input = Console.ReadLine();
                if (int.TryParse(input, out number) && number >= min && number <= max)
                {
                    return number;
                }
                else if (number < min && number > max)
                {
                    Console.WriteLine("Not in the valid range");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    Console.ReadLine();
                }
            }
        }
    }

}