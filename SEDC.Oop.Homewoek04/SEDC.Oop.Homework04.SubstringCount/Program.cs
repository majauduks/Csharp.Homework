using System;
using System.Text.RegularExpressions;

namespace SEDC.Oop.Homework04.SubstringCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string!");
            string input = Console.ReadLine();
            Console.WriteLine("Enter what you want to check if is repeated");
            string repeated = Console.ReadLine();
            Console.WriteLine($@"The expression ""{repeated}"" is repeated {SubstringCount(input, repeated)} many times within the expression ""{input}""");
        }

        public static int SubstringCount(string input, string repeated)
        {
            int substringCount;
            substringCount = Regex.Matches(input, repeated).Count;
            return substringCount;
        }
    }
}
