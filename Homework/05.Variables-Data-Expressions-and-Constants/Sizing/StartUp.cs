using System;

namespace Sizing
{
    public class StartUp
    {
        internal static void Main()
        {
            Size size = new Size(2.5, 5);
            Size rotatedSize =Size.GetRotatedSize(size, 90);
            Console.WriteLine("{0:F2}", rotatedSize.width);
            Console.WriteLine("{0:F2}", rotatedSize.heigth);
        }
    }
}
