using System;
using System.Collections.Generic;
using static System.Console;
namespace WhileApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //while 예제
            int i = 10;
            while (i > 0)
            {
                WriteLine($"{i--}");
            }

            //foreach
            //리스트 선언 - > Add
            List<string> strings = new List<string>();
            strings.Add("Hello");
            strings.Add("Bye");
            strings.Add("Hey~");
            //리스트에 리스트 Add
            List<string> subs = new List<string> { "Banana", "Strawberry" };
            strings.AddRange(subs);
            //foreach 사용 예제
            foreach (string item in strings)
            {
                WriteLine(item);
            }
        }
    }
}
