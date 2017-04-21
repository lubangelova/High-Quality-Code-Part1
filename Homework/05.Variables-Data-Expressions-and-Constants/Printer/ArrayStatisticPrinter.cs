using System;
using System.Linq;

namespace Printing
{
    public class ArrayStatisticPrinter
    {
        public void PrintStatistics(double[] arr, int count)
        {
            double max = arr.Max();
            double min = arr.Min();
            double average = arr.Average();

            Print($"Max element: {max}");
            Print($"Min element: {min}");
            Print($"Average: {average}");

        }    
        public void Print (string text)
        {
            Console.WriteLine(text);
        }   
    }
}
