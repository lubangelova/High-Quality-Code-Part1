using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Magical_numbers
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int thirdDigit = number % 10;
            int secondDigit = (number % 100)/10;
            int firstDigit = number / 100;
            double result = 0;

            if (secondDigit%2==0)
            {
                result = (firstDigit + secondDigit) * thirdDigit;
            }
            else
            {
                result = (firstDigit * secondDigit) / (double)thirdDigit;
            }

            Console.WriteLine("{0:F2}", result);
        }
    }
}
