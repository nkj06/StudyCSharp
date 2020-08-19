using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegralConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte a = sbyte.MaxValue; // 127
            Console.WriteLine($"a = {a}");
            int b = (int)a;
            Console.WriteLine($"b = {b}");
            int x = 128;
            Console.WriteLine($"x = {x}");
            // sbyte y = x;  // 큰 변수 타입을 작은 변수 타입에 대입 불가 (오버플로우 발생), 형 변환 해줘야 함
            sbyte y = (sbyte)x;
            Console.WriteLine($"y = {y}");
        }
    }
}
