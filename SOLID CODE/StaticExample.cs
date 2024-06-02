using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_CODE
{
    public class StaticExample
    {
        public int a,b;

        public static int count;

        static StaticExample()
        {
            count = 0; // Statik değişkenlerin başlangıç değerini atamak için kullanılır
            Console.WriteLine("Static constructor is executed.");
        }
        public StaticExample(int a, int b)
        {
            this.a = a;
            this.b = b;

            count += 1;
        }

        public void Toplama(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public static void Cikarma(int a, int b)
        {
            Console.WriteLine(a - b);
        }
    }
}
