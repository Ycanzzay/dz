﻿using System;
using System.Linq;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the numbers without a space");
        string input = Console.ReadLine();
        int[] numbers = input.Split(' ')
                             .Select(int.Parse).ToArray();

        int[] result = MoveZerosToEnd(numbers);
        Console.WriteLine("The array after moving the zeros " + string.Join(", ", result));
    }
    static int[] MoveZerosToEnd(int[] arr)
    {
        int[] nonZero = arr.Where(num => num != 0).ToArray();
        int zeroCount = arr.Length - nonZero.Length;
        int[] result = new int[arr.Length];
        Array.Copy(nonZero, result, nonZero.Length); return result;
    }
}