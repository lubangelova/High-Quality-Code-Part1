namespace Printing
{
    public class StartUp
    {
        internal static void Main()
        {
            var arrayPrinter = new ArrayStatisticPrinter();
            double[] array = new double[] { 2.15, 52.2, -12.3, 0.56, -2 };
            int count = array.Length;          
            arrayPrinter.PrintStatistics(array, count);
        }
    }
}
