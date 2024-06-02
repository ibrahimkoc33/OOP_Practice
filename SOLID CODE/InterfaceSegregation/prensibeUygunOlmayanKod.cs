using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_CODE.Interface_Segregation
{
    public class prensibeUygunOlmayanKod
    {
    }

    public interface IAnimal
    {
        void Eat();
        void Fly();
        void Bark();
    }

    public class Dog : IAnimal
    {
        public void Eat()
        {
            Console.WriteLine("Dog is eating.");
        }

        public void Fly()
        {
            throw new NotImplementedException("Dogs can't fly.");
        }

        public void Bark()
        {
            Console.WriteLine("Dog is barking.");
        }
    }

    public class Bird : IAnimal
    {
        public void Eat()
        {
            Console.WriteLine("Bird is eating.");
        }

        public void Fly()
        {
            Console.WriteLine("Bird is flying.");
        }

        public void Bark()
        {
            throw new NotImplementedException("Birds can't bark.");
        }
    }
}
