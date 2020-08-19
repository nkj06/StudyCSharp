using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _362_Indexer
{
    class MyList
    {
        private int[] array;

        public MyList()
        {
            array = new int[3];
        }
        public int this[int index]
        {
            get { return array[index]; }
            set
            {
                if(index >= array.Length)
                {
                    Array.Resize<int>(ref array, index + 1);
                    Console.WriteLine($"Array Resize : {array.Length}");
                }
                array[index] = value;
            }
        }
        public int Length
        {
            get { return array.Length; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyList list = new MyList();

            //list[0] = 1;
            //list[1] = 2;
            //list[2] = 3;
            //list[3] = 4;

            for (int i = 0; i < 5; i++) // 인덱스를 쓰면 숫자가 몇개든 괜츈
                list[i] = i;

            for (int i = 0; i < list.Length; i++)
                Console.WriteLine(list[i]);
        }
    }
}
