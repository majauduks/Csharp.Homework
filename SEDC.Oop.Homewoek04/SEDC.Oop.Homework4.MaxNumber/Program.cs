using System;

namespace SEDC.Oop.Homework4.MaxNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            int[] numbers =
            {
                1,
                423,
                543,
                12,
                3,
                9643
            };

            Console.WriteLine($"The maximum number is {MaxNumber(numbers)}");
        }
        public static int MaxNumber(int[] arrayToSearch)
        {
            int max = 0;
            foreach (int number in arrayToSearch)
            {
                if (number > max)
                    max = number;
            }
            return max;
        }
    }
}
