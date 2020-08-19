using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _491_FromFrom
{
    class Subject
    {
        public string Name { get; set; }
        public int[] Score { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Subject> subjects = new List<Subject>
            {
                new Subject { Name = "연두반", Score = new int[] {99,80,70,24} },
                new Subject { Name = "분홍반", Score = new int[] {60,45,87,72} },
                new Subject { Name = "파랑반", Score = new int[] {92,30,85,94} },
                new Subject { Name = "노랑반", Score = new int[] {90,88,0,17} }
            };

            var newSubject = from c in subjects
                             from s in c.Score
                             where s < 60
                             orderby s
                             select new { c.Name, Lowest = s };

            foreach (var c in newSubject)
                Console.WriteLine($"낙제 : {c.Name} ({c.Lowest})");
            {

            }
        }
    }
}
