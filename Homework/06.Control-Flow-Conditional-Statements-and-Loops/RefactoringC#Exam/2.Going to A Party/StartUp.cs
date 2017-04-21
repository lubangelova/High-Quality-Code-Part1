using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Going_to_A_Party
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int position = 0;
            for (int i = 0; i < text.Length; i += position)
            {
                char ch = text[i];
                if ('a' <= ch && ch <= 'z')
                {
                    position = ch - 'a' + 1;

                }
                else if ('A' <= ch && ch <= 'Z')
                {
                    position = -(ch - 'A' + 1);

                }
                else if (ch == '^')
                {
                    position = i;
                    Console.WriteLine("Djor and Djano are at the party at {0}!", position);
                    break;

                }
                if (i + position > text.Length || i + position < 0)
                {
                    Console.WriteLine("Djor and Djano are lost at {0}!", i + position);
                    break;

                }
            }
        }
    }
}

