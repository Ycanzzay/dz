namespace ConsoleApp14
{
    using System;
    using System.Collections.Generic;

    namespace Kata
    {
        public class FindFirstNonRepeatingLetter
        {
            public static char FindFirstNonRepeatingLetterInString(string inputString)
            {
                Dictionary<char, int> letterCounts = new Dictionary<char, int>();

                foreach (char letter in inputString.ToLower())
                {
                    if (letterCounts.ContainsKey(letter))
                    {
                        letterCounts[letter]++;
                    }
                    else
                    {
                        letterCounts.Add(letter, 1);
                    }
                }

                foreach (char letter in inputString.ToLower())
                {
                    if (letterCounts[letter] == 1)
                    {
                        return letter;
                    }
                }

                return ' ';
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}