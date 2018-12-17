using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace chap21._11
{
    class Program
    {
        static void Main(string[] args)
        {
            var values = new List<int> { 3, 10, 6, 1, 4, 8, 2, 5, 9, 7 };

            Console.Write("Original values: ");
            values.Display();//call Display extension method

            //display the Min, Max, Sum and Average
            Console.WriteLine($"\nMin: {values.Min()}");
            Console.WriteLine($"Max: {values.Max()}");
            Console.WriteLine($"Sum: {values.Sum()}");
            Console.WriteLine($"Average: {values.Average()}");

            //sum of values via Aggrate
            Console.WriteLine("\nSum via aggrate method: " +
                values.Aggregate(0, (x,y) => x + y));

            //sum of squares of vlaues via Aggregate
            Console.WriteLine("Sum of squares via Aggrage method: " +
                values.Aggregate(0, (x, y) => x + y * y));

            //product of values via Aggrate
            Console.WriteLine("Product via Aggrate method: " + 
                values.Aggregate(1,(x,y) => x * y));

            //even values displayed in sorted order
            Console.Write("\nEven values displayed in sorted order: ");
            values.Where(value => value % 2 == 0)//find even integers
                .OrderBy(value => value) //sort remaining values
                .Display();

            //odd values multiplied by 10 and displayed in sorted order
            Console.Write(
                "Odd values multiplied by 10 displayed in sorted order: ");
            values.Where(value => value % 2 != 0)//find odd integers
                .Select(value => value * 10)//multiply each by 10
                .OrderBy(value => value)//sort the values
                .Display();//show results

            //display original values again to prove they were not modified
            Console.Write("\nOriginal values: ");
            values.Display();
            Console.Read();
        }
    }

    //declares an extension method
    static class Extensions
    {
        //extension method that displays all elements separted spaces
        public static void Display<T>(this IEnumerable<T> data)
        {
            Console.WriteLine(string.Join(" ", data));
        }
    }
}
