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
            Console.WriteLine($"The substring count is {SubstringCount(input, repeated)}");
            
            }


        public static int SubstringCount(string input, string repeated)
        {
            int counter = 0;
            int m = repeated.Length;

            for (int i = 0; i <= input.Length - m; i++)
            {
                string substring = input.Substring(i, m);
                if (substring == repeated)
                {
                    counter++;

                }
            }
            return counter;
        }

        }
    }




          
