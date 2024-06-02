using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_CODE.LiskovSubstitution
{
    public class prensibeUygunKod
    {
    }

    public abstract class Shape4
    {
        public abstract double CalculateArea4();
    }

    public class Rectangle4 : Shape4
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle4(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea4()
        {
            return Width * Height;
        }
    }

    public class Square4 : Shape4
    {
        public double Side { get; set; }

        public Square4(double side)
        {
            Side = side;
        }

        public override double CalculateArea4()
        {
            return Side * Side;
        }
    }
}
