using System;

namespace Methods
{
    public class Methods
    {
        public static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Sides should be positive.");
            }

            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }

        public static string NumberToDigit(int number)
        {
            string numberToDigit = string.Empty;
            switch (number)
            {
                case 0: numberToDigit = "zero";
                    break;
                case 1: numberToDigit = "one";
                    break;
                case 2: numberToDigit = "two";
                    break;
                case 3: numberToDigit = "three";
                    break;
                case 4: numberToDigit = "four";
                    break;
                case 5: numberToDigit = "five";
                    break;
                case 6: numberToDigit = "six";
                    break;
                case 7: numberToDigit = "seven";
                    break;
                case 8: numberToDigit = "eight";
                    break;
                case 9: numberToDigit = "nine";
                    break;
                default: numberToDigit = "Invalid number!";
                    break;
            }

            return numberToDigit;
        }

        public static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentException("Elements can not be null.");
            }

            int max = int.MinValue;
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] > max)
                {
                    max = elements[i];
                }
            }

            return max;
        }

        public static void PrintAsNumber(object number, string format)
        {
            string printFormat = string.Empty;
            if (format == "f")
            {
                printFormat = "{0:f2}";               
            }

            if (format == "%")
            {
                printFormat = "{0:p0}";
            }

            if (format == "r")
            {
                printFormat = "{0,8}";
            }

            Console.WriteLine(printFormat, number);
        }

        public static double CalcDistance(Line line1, Line line2)
        {
            double distance = Math.Sqrt((line2.X - line1.X) * (line2.X - line1.X) + (line2.Y - line1.Y) * (line2.Y - line1.Y));
            return distance;
        }

        public static bool IsHorizontal(Line line1, Line line2)
        {
            if (line1.Y == line2.Y)
            {
                return true;
            }

            return false;
        }

        public static bool IsVertical(Line line1, Line line2)
        {
            if (line1.X == line2.X)
            {
                return true;
            }

            return false;
        }
    }
}
