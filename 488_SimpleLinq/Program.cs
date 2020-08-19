using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _488_SimpleLinq
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // 책 배열
            Profile[] arrProfile =
            {
                new Profile(){Name = "정우성", Height = 186},
                new Profile(){Name = "김태희", Height = 158},
                new Profile(){Name = "고현정", Height = 172},
                new Profile(){Name = "이문세", Height = 178},
                new Profile(){Name = "하하", Height = 171}
            };
            */

            // 실무에서는 배열보다 리스트를 사용
            List<Profile> profiles = new List<Profile>
            {
                new Profile(){Name = "정우성", Height = 186},
                new Profile(){Name = "김태희", Height = 158},
                new Profile(){Name = "고현정", Height = 172},
                new Profile(){Name = "이문세", Height = 178},
                new Profile(){Name = "하하", Height = 171}
            };

            var newprofiles = from item in profiles
                           where item.Height < 175
                           orderby item.Height
                           select new
                           {
                               Name = item.Name,
                               InchHeight = item.Height * 0.39
                           };

            foreach (var item in newprofiles)
                Console.WriteLine($"{item.Name}, {item.InchHeight}");
        }
    }
}
