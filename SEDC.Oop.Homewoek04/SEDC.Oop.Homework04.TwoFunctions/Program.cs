using System;

namespace SEDC.Oop.Homework04.TwoFunctions
{
    internal class Program
    { static void Main(string[] args)
        {
            string someString = "483274823nfjAAAasf8--&^#&$*^$&@#8";
            Console.WriteLine(($"There are exactly {CheckNumberCount(someString)} numbers in the string!"));
            Console.WriteLine(($"There are this many: {CheckVowelCount(someString)} vowels in the string!" ));
        }

        public static int CheckVowelCount (string stringToCheck)
        {
            int count = 0;

            string lowerCharacters = stringToCheck.ToLower();

            foreach(char character in lowerCharacters)
            {
                if(character == 'a' || character == 'e' || character =='o' || character =='u' || character == 'i' )
                {
                    count++;
                }

            }

            return count;
        }

            public static int CheckNumberCount (string stringToCheck)
            {
                int count = 0;

                foreach (char character in stringToCheck)
                {
                    if (Char.IsDigit(character))
                    {
                        count++;
                    }


                }

                return count;
            }
        }

    }
