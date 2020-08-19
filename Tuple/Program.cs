using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            //  명명되지 않은 튜플
            var a = ("슈퍼맨", 56, "크립톤");
            Console.WriteLine($"{a.Item1}, {a.Item2}, {a.Item3}");
            Console.WriteLine($"{a.Item1.GetType()}, {a.Item2.GetType()}, {a.Item3.GetType()}");

            //  명명된 튜플
            var b = (Name: "김민수", Age: "27", Home: "포항");
            Console.WriteLine($"{b.Name}, {b.Age}, {b.Home}");

            // 분해
            var (name, age, home) = b;
            Console.WriteLine($"{name}, {age}, {home}");

        }
    }
}