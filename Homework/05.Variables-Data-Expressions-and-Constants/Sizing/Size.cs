using System;

namespace Sizing
{
    public class Size
    {
        public double width;
        public double heigth;

        public Size(double width, double heigth)
        {
            this.width = width;
            this.heigth = heigth;
        }

        public static Size GetRotatedSize(Size size, double angleToRotate)
        {
            double cosOfAngle = Math.Abs(Math.Cos(angleToRotate));
            double sinOfAngle = Math.Abs(Math.Sin(angleToRotate));

            double rotatedWidth = (cosOfAngle * size.width) + (sinOfAngle * size.heigth);
            double rotatedHeigth = (sinOfAngle * size.width) + (cosOfAngle * size.heigth);

            Size rotatedSize = new Size(rotatedWidth, rotatedHeigth);

            return rotatedSize;
        }
    }
}
