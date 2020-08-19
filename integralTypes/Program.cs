using static System.Console;

namespace integralTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //sbyte a = sbyte.MaxValue;
            //byte b = byte.MinValue;

            //short c = short.MinValue;
            //ushort d = ushort.MaxValue;

            //int e = int.MinValue;
            //uint f = uint.MaxValue;

            //long g = long.MaxValue;
            //ulong h = ulong.MaxValue;

            //ulong i = 20_000_000_000;
            //Console.WriteLine(i);

            //byte a = 240;
            //WriteLine($"a = {a}");
            //byte b = 0b1111_0000;
            //WriteLine($"b = {b}");
            //byte c = 0xf0;
            //WriteLine($"c = {c}");

            byte d = byte.MaxValue;
            WriteLine($"d = {d}");
            d += 1; // 오버 플로우가 발생함
            WriteLine($"d = {d}");

            float f = float.MaxValue;
            double g = double.MaxValue;

        }
    }
}
