using System;
using System.Collections;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        { 
            var numbers = new List<int>();
            var num = 0;
            do
            {
                numbers.Add(num);
                num++;
            } while (num < 100);
            while (num < 200)
            {
                num++;
                numbers.Add(num);
            }
            Console.WriteLine("Increase:");
            foreach (var number in numbers)
            {
                Console.WriteLine($"{number/*s*/}");
            } 
            Console.WriteLine("");
            Console.WriteLine("Decrease:");
            for (int i = 199; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }

        }
    }
}
