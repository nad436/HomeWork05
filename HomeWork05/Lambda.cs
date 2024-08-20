using System;
using System.Collections.Generic;

namespace HomeWork05
{
    public class Lambda
    {
       public static void LambdaExpression(List<int> numbers)
        {
           
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

