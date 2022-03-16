using System;

namespace SEDC.Oop.Homework04.IsAlphabet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some input");
            string input = Console.ReadLine();
            CheckIfAlphabeticalAndCase(input);
        }

        public static string CheckIfAlphabeticalAndCase (string input)
            {

            int countUpper = 0;
            int countLower = 0;
            int counterLetters = 0;
            foreach(char c in input)
            {
                if(char.IsLetter(c))
                {
                    counterLetters++;
                    if (char.IsUpper(c))
                    {
                        countUpper++;
                    }

                    else
                        countLower++;
                }
            }

            string sentence = string.Empty;
           sentence =  string.Format("There are {0} letters in this sentence altogether, out of which {1} are upper case and {2} are lower case letters", counterLetters, countUpper, countLower);
            Console.WriteLine(sentence);
            return sentence;
            }
    }
}
