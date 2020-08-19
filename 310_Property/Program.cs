using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;

namespace _32_Property
{
    class BirthdayInfo
    {
        private string name;
        private DateTime birthday;
        /*
        public void SetName(string name)
        {
            this.name = name;
        }
        
        public void SetBirthday(DateTime birth)
        {
            birthday = birth;
        }

        public string GetName()
        {
            return name;
        }

        public DateTime GetBirthday()
        {
            return birthday;
        }
        */
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        /*
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }*/
        // public string Name { get; set; }
        // 논리적인 로직이 없다면 이렇게 더 줄일 수 있다.

        // 초기화도 가능함
        //public string Name { get; set; } = "Unknown";
        //public DateTime Birthday { get; set; } = new DateTime(1900, 1, 1);
        //public string Phonenumber { get; set; } = "000-0000-0000";

        public DateTime Birthday
        {
            get
            {
                return birthday;
            }
            set
            {
                if (value.Year >= DateTime.Now.Year)
                    birthday = DateTime.Now;
                else
                    birthday = value;
            }
        }

        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(birthday).Ticks).Year;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BirthdayInfo info = new BirthdayInfo();
            /*
            info.SetName("박서현");
            info.SetBirthday(new DateTime(1991, 6, 28));

            WriteLine($"Name : {info.GetName()}");
            WriteLine($"Birthday : {info.GetBirthday().ToShortDateString()}");
            */

            info.Name = "박서현";
            info.Birthday = new DateTime(1991, 6, 28);

            WriteLine($"Name : {info.Name}");
            WriteLine($"Birthday : {info.Birthday.ToShortDateString()}");
            WriteLine($"Age : {info.Age}");

            WriteLine($"{info.Name}, {info.Birthday} 출생");
            WriteLine($"{info.Age}세");

            var myIns = new { Name = "남경진", Home = "마산" };
            WriteLine($"{myIns.Name} / {myIns.Home}");

            var b = new { Subject = "수학", Scores = new int[] { 99, 88, 77 } };
            WriteLine($"{b.Subject}");
            foreach(var item in b.Scores)
            {
                WriteLine($"{item}");
            }
        }
    }
}