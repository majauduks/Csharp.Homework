using System;

namespace SEDC.Oop.Homework04.Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string toCheckIfPalindrome = string.Empty;

            Console.WriteLine("Enter what you want to be checked");
            toCheckIfPalindrome = Console.ReadLine();

            char[] letters = toCheckIfPalindrome.ToCharArray();

            int j = letters.Length - 1;

            if (letters.Length % 2 == 0)
            {
                for (int i = 0; i < letters.Length; i++)
                {
                    if (letters[i] == letters[j])
                    {
                        if (i + 1 == j && letters[i] == letters[j])
                        {
                            Console.WriteLine("The word is a palindrome");
                            break;
                        }
                        j--;
                        continue;
                    }

                    Console.WriteLine("It is not a palindrome");
                    break;
                }
            }
            else
            {
                j = letters.Length - 1;
                for (int i = 0; i < letters.Length; i++)
                {
                    if (letters[i] == letters[j])
                    {
                        if (i == j && letters[i] == letters[j])
                        {
                            Console.WriteLine("The word is a palindrome");
                            break;
                        }

                        j--;
                        continue;
                    }

                    Console.WriteLine("The word is not a palindrome");
                    break;
                }

            }
        }
    }
}
