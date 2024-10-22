namespace ConsoleApp15
{
    using System;

    namespace Kata
    {
        public class ToGamelCase
        {
            public static string ToGamelCaseString(string inputString)
            {
                string[] words = inputString.Split(' ');
                string gamelCaseString = "";

                for (int i = 0; i < words.Length; i++)
                {
                    if (i == 0)
                    {
                        gamelCaseString += words[i].Substring(0, 1).ToUpper() + words[i].Substring(1).ToLower();
                    }
                    else
                    {
                        gamelCaseString += words[i].Substring(0, 1).ToUpper() + words[i].Substring(1).ToLower();
                    }
                }

                return gamelCaseString;
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