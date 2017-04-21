using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Secret_message
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string text = "";
            string start = "";
            string end = "";
            while (true)
            {
                start = Console.ReadLine();
                end = Console.ReadLine();
                text = Console.ReadLine();
                if (start == "end")
                {
                    break;
                }

            }

            string result = "";         
            for (int i = int.Parse(start); i < int.Parse(end); i += 3)
            {
                char ch = text[i];
                result += ch.ToString();
            }

            Console.WriteLine(result);
        }
    }
}
