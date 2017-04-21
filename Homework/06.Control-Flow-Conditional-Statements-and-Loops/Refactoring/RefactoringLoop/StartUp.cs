using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringLoop
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int arrLength = 100;
            int[] array = new int[arrLength];
            int expectedValue = default(int);

            for (var i = 0; i < arrLength; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine(array[i]);
                    
                    if (array[i] == expectedValue)
                    {                       
                        Console.WriteLine("Value Found");
                        break;
                    }                  
                }
                else
                {
                    Console.WriteLine(array[i]);                 
                }
            }          
        }
    }
}
