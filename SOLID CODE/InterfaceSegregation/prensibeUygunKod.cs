using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_CODE.Interface_Segregation
{
    public class prensibeUygunKod
    {
    }

    public interface IAnimal2
    {
        void Eat();
    }

    public interface IFlyable
    {
        void Fly();
    }

    public interface IBarkable
    {
        void Bark();
    }

    public class Dog2 : IAnimal2, IBarkable
    {
        public void Eat()
        {
            Console.WriteLine("Dog is eating.");
        }

        public void Bark()
        {
            Console.WriteLine("Dog is barking.");
        }
    }

    public class Bird2 : IAnimal2, IFlyable
    {
        public void Eat()
        {
            Console.WriteLine("Bird is eating.");
        }

        public void Fly()
        {
            Console.WriteLine("Bird is flying.");
        }
    }
}
