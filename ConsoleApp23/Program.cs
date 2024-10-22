using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();

        
        Dictionary<char, int> letterCount = new Dictionary<char, int>();

       
        foreach (char c in input)
        {
            if (char.IsLetter(c)) 
            {
                char upperChar = char.ToUpper(c);
                if (letterCount.ContainsKey(upperChar))
                {
                    letterCount[upperChar]++;
                }
                else
                {
                    letterCount[upperChar] = 1;
                }
            }
        }

        // Выводим результат
        foreach (var kvp in letterCount)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}