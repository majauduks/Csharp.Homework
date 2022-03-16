using System;

namespace SEDC.Oop.Homework04.ToThePoweOf
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool flag = false;

            while (!flag)
            {
            Console.WriteLine("Enter the base number");
                string baseNumberInput = Console.ReadLine();
            bool isBaseOkay = int.TryParse(baseNumberInput, out int baseNumber);
                if (!isBaseOkay)
                {
                    Console.WriteLine("Enter a valid number");
                    continue;
                }
                Console.WriteLine("Enter the power to which you want it to be");
                string powerInput = Console.ReadLine();
                bool isPoweOkay = int.TryParse(powerInput, out int power);
               if (!isPoweOkay)
                {
                    Console.WriteLine("Enter a valid number");
                    continue;
                }

               Console.WriteLine($"The number {baseNumber} to the power of {power} gives us the number {ToThePowerOf(baseNumber, power)}!");

                flag = true;
            }
        }

        public static double ToThePowerOf (int baseNumber, int power)
        {
            double result = 0;
            result = Math.Pow(baseNumber, power);
            return result;
        }
    }
}
