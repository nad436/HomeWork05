using System;
using System.Collections.Generic;

namespace HomeWork05
{
    internal class Lambda
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 23, 34, 12, 69, 2, 33, 93, 45, 89 };
            Console.Write("List:");
            foreach (int i in numbers)
            {
                Console.Write($" {i} ");
            }
            Console.WriteLine();
            Console.Write("Pair numbers:");
            numbers.ForEach(x =>
            {
                if (x % 2 == 0)
                {
                    Console.Write($" {x} ");
                }
            });
            Console.WriteLine();

            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Bigger than {number}:");
            numbers.ForEach(x =>
            {
                if (number < x)
                {
                    Console.Write($" {x} ");
                }
            }
            );

        }
    }
}

