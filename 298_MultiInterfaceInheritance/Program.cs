using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _298_MultiInterfaceInheritance
{
    interface IRunnable
    {
        void Run();
    }
    interface IFlyable
    {
        void Fly();
    }

    class Vehicle
    {
        public string Year;
        public string Company;
        public float Holsepower;
    }
    class FlyingCar : Vehicle, IRunnable, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Fly!");
        }
        public void Run()
        {
            Console.WriteLine("Run!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FlyingCar car = new FlyingCar();
            car.Run();
            car.Fly();
            car.Company = "현대";

            IRunnable runnable = car;
            runnable.Run();

            IFlyable flyable = car;
            flyable.Fly();
        }
    }
}
