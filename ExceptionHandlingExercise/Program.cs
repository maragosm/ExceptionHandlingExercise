using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new char[] { '1', '2', '3', '4', '5', '6', 'a', 'b', 'c' };

            var numbers = new List<int>();

            var str = "";

            foreach (var item in arr)
            {
                try
                {
                    str = item.ToString();
                    numbers.Add(int.Parse(str));
                }
                catch (FormatException e)
                {
                    Console.WriteLine($"Unable to Parse {item}");
                }
            }

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
