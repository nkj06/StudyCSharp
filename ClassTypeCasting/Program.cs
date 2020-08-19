using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTypeCasting
{
    class Program
    {
        class Mammal // 포유류
        {
            public void Nurse()
            {
                Console.WriteLine("Nurse()");
            }
        }
        class Dog : Mammal
        {
            public void Bark()
            {
                Console.WriteLine("bark()");
            }
        }

        class Cat : Mammal
        {
            public void Meow()
            {
                Console.WriteLine("Meow()");
            }
        }

        static void Main(string[] args)
        {
            Mammal mammal = new Dog();
            Dog dog;

            if(mammal is Dog)
            {
                dog = mammal as D
                    og;
                dog.Bark();
            }
        }
    }
}
