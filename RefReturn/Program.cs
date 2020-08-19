using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefReturn
{
    class Product
    {
        private int price = 100;
        public ref int GetPrice()
        {
            return ref price;
        }
        public void printPrice()
        {
            Console.WriteLine($"Price : {price}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product carrot = new Product();
            int local_price = carrot.GetPrice();
            carrot.printPrice();

            local_price = 3000;
            carrot.printPrice();
            Console.WriteLine($"local_price = {local_price}");
        }
    }
}
