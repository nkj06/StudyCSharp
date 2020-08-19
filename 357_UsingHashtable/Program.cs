using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _357_UsingHashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht["이름"] = "남경진";
            ht["주소"] = "경상남도 창원시";
            ht["전번"] = "010-1111-1111";
            ht["키"] = 168.0;
            ht["결혼 여부"] = false;

            Console.WriteLine(ht["키"]);
            Console.WriteLine($"{ht["키"]:0.0}");

            Console.WriteLine(ht["결혼 여부"]);
        }
    }
}
