using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstraintsOnTypeParameters
{
    class StructArray<T> where T : struct // 가변식 (구조체, int, double)
    {
        public T[] Array { get; set; }
        public StructArray(int size)
        {
            Array = new T[size];
        }
    }

    class RefArray<T> where T : class // 참조형식 (클래스, 배열)
    {
        public T[] Array { get; set; }
        public RefArray(int size)
        {
            Array = new T[size];
        }
    }

    class Base { }
    class Derived : Base { }
    class BaseArray<U> where U : Base // Base 클래스만 사용가능
    {
        public U[] Array { get; set; }
        public BaseArray(int size)
        {
            Array = new U[size];
        }
        public void CopyArray<T>(T[] Source) where T : U // U랑 Base랑 차이없음
        {
            Source.CopyTo(Array, 0);
        }
    }
    class Program
    {
        public static T CreateInstance<T>()where T : new()
        {
            return new T();
        }
        static void Main(string[] args)
        {
            StructArray<int> a = new StructArray<int>(3); // int는 가변식
            a.Array[0] = 0;
            a.Array[1] = 1;
            a.Array[2] = 2;
            // StructArray<string> b = new StructArray<string>(3); // string은 참조 형식(배열이라) 안됨

            RefArray<StructArray<double>> b = new RefArray<StructArray<double>>(3);
            b.Array[0] = new StructArray<double>(5);
            b.Array[1] = new StructArray<double>(10);
            b.Array[2] = new StructArray<double>(1005);

            BaseArray<Base> c = new BaseArray<Base>(3); // BaseArray만 사용할 수 있게 해서 int 는 안됨
            c.Array[0] = new Base();
            c.Array[1] = new Derived();
            c.Array[2] = CreateInstance<Base>();

            BaseArray<Derived> d = new BaseArray<Derived>(3);
            d.Array[0] = new Derived(); // Base 형식은 여기에 할당 할 수 없다.
            d.Array[1] = CreateInstance<Derived>();
            d.Array[2] = CreateInstance<Derived>();

            BaseArray<Derived> e = new BaseArray<Derived>(3);
            e.CopyArray<Derived>(d.Array);

        }
    }
}
