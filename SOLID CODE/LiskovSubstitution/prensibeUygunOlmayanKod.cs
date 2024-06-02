using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_CODE.LiskovSubstitution
{
    public class prensibeUygunOlmayanKod
    {
    }

    //Bu kodda kare sınıfı dikdörtgen sınıfından türetilmiş ancak kare sınıfını dikdörtgen sınıfının yerine kullandığımızda
    //beklenmeyen davranışlar ortaya çıkar. Square sınıfında Width ve Height özelliklerinin birbirine eşit olması gerekliliği,
    //Rectangle sınıfının mantığını bozar ve LSP'yi ihlal eder.
    public class Rectangle3
    {
        public virtual double Width { get; set; }
        public virtual double Height { get; set; }

        public double CalculateArea3()
        {
            return Width * Height;
        }
    }

    public class Square3 : Rectangle3
    {
        public override double Width
        {
            get { return base.Width; }
            set { base.Width = base.Height = value; }
        }

        public override double Height
        {
            get { return base.Height; }
            set { base.Height = base.Width = value; }
        }
    }
}
