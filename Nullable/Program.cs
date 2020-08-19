using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a = null;
            double? b = null;
            float? c = null;
            string s = null;

            //Console.WriteLine(a.HasValue);
            //Console.WriteLine(a.Value); // 널값은 화면에 찍을 수 없어서 에러남

            if (a.HasValue)
            {
                Console.WriteLine(a.Value); // 널값은 화면에 찍을 수 없어서 에러남
            }
            Console.WriteLine(b == null);
            Console.WriteLine(string.IsNullOrEmpty(s));
            Console.WriteLine(string.IsNullOrWhiteSpace(s));

            c = 3.141592F;
            if(c.HasValue)
            {
                Console.WriteLine($"c = {c.Value}");
            }    
        }
    }
}
