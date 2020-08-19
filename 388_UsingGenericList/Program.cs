using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _388_UsingGenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            List<int> list = new List<int>();
            for (int i = 0; i < 5; i++)
                list.Add(i);

            foreach (int element in list)
                Console.Write($"{element}");
            Console.WriteLine();

            list.RemoveAt(2);

            foreach (int element in list)
                Console.Write($"{element}");
            Console.WriteLine();

            list.Insert(2, 2);

            foreach (int element in list)
                Console.Write($"{element}");
            Console.WriteLine();
            */

            /*
            Queue<double> q = new Queue<double>();
            q.Enqueue(11.1);
            q.Enqueue(22.2);
            q.Enqueue(33.3);
            q.Enqueue(44.4);

            while(q.Count > 0)
            {
                Console.WriteLine(q.Dequeue());
            }
            */

            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic["하나"] = 100;
            dic["둘"] = 200;
            dic["셋"] = 300;
            dic["넷"] = 400;

            Console.WriteLine(dic["하나"]);
        }
    }
}
