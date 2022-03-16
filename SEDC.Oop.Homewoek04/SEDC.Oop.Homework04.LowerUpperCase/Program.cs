using System;

namespace SEDC.Oop.Homework04.LowerUpperCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some input");
            string input = Console.ReadLine();
            Console.WriteLine(LowerUpperCrossover(input));
        }

        public static string LowerUpperCrossover(string input)
        {
            string result = string.Empty;
            foreach (char c in input)
            {
                if (char.IsUpper(c))
                {
                    result += char.ToLower(c);
                }
                else
                {
                    result += char.ToUpper(c);
                }
            }
                return result;
        }
    }
}