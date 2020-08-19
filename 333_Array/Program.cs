using System;
using System.Collections;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _351_UsingList
{
    class Program
    {
        static void Main(string[] args)
        {
            // ArrayList list = new ArrayList();

            ArrayList list = new ArrayList() { 123, 456, 789 }; // 초기화 이렇게 가능

            for (int i = 0; i < 10; i++)
            {
                int iresult = list.Add(i);
                WriteLine($"{iresult}번째에 데이터 {i}추가 완료");
            }

            foreach (var item in list)
            {
                Write($"{item}, ");
            }
            WriteLine();
            //삭제
            list.RemoveAt(2);
            foreach (var item in list)
            {
                Write($"{item}, ");
            }
            WriteLine();
            //삽입
            list.Insert(5, 4.5);
            foreach (var item in list)
            {
                Write($"{item}, ");
            }
            WriteLine();
            //클리어
            list.Clear();
            WriteLine("After Clear()");
            foreach (var item in list)
            {
                Write($"{item}, ");
            }
            WriteLine();

        }
    }
}
