using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Merging_Numbers
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int numbersLength = int.Parse(Console.ReadLine());
            int mergedNumbers;
            int sums = 0;
            int[] numbers = new int[numbersLength];
            int[] arraySumms = new int[numbersLength - 1];
            int[] arrayMerged = new int[numbersLength - 1];
            for (int i = 0; i < numbersLength; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numbersLength - 1; i++)
            {
                sums = numbers[i] + numbers[i + 1];
                mergedNumbers = int.Parse((numbers[i] % 10).ToString() + (numbers[i + 1] / 10).ToString());
                for (int j = 0; j < numbersLength - 1; j++)
                {
                    arraySumms[i] = sums;
                    arrayMerged[i] = mergedNumbers;
                }
            }

            PrintArray(arrayMerged);
            PrintArray(arraySumms);
        }

        private static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }
    }
}
