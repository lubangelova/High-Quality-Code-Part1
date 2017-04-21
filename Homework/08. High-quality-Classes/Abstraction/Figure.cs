using System;
using System.Text;

namespace Abstraction
{
    public abstract class Figure : IFigure
    {     

        public abstract double CalcPerimeter();

        public abstract double CalcSurface();

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine($"I am a {this.GetType().Name.ToLower()}.");
            builder.AppendLine($"My perimeter is {this.CalcPerimeter():f2}.");
            builder.AppendLine($"My surface is {this.CalcSurface():f2}.");
            return builder.ToString();
        }

    }
}
