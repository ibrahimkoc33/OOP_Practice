using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_CODE.OpenClosed
{
    public class prensibeUygunOlmayanKod
    {
    }

    // Bu kodda shape() sınıfı genişletme açıktır. Yeni bir şekil eklenmek istendiği zaman kodu değiştirmeye gerek kalmaz.
    public abstract class Shape2
    {
        public abstract double CalculateArea2();
    }

    // Circle class
    public class Circle2 : Shape2
    {
        public double Radius { get; set; }

        public Circle2(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea2()
        {
            return Math.PI * Radius * Radius;
        }
    }

    // Rectangle class
    public class Rectangle2 : Shape2
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle2(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea2()
        {
            return Width * Height;
        }
    }
}
