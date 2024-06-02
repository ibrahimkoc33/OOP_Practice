using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_CODE.OpenClosed
{
    public class prensibeUygunKod
    {
    }

    // Bu kod OCP ihlal eder. Mesela kare sınıfını eklemek istediğimizde kodu değiştirmemiz gerekir
    public class Shape
    {
        public string Type { get; set; }
        public double Radius { get; set; } // Only for circles
        public double Width { get; set; }  // Only for rectangles
        public double Height { get; set; } // Only for rectangles

        public double CalculateArea()
        {
            if (Type == "Daire")
            {
                return Math.PI * Radius * Radius;
            }
            else if (Type == "Dikdortgen")
            {
                return Width * Height;
            }
            else
            {
                throw new NotSupportedException("Shape type is not supported");
            }
        }
    }
}
