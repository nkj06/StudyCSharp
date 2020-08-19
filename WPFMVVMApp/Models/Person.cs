using System;
using System.Web.UI.WebControls.WebParts;
using WPFMVVMApp.Helpers;

namespace WPFMVVMApp.Models
{
    public class Person
    {
        public string FirstName { get; set; }//Table 상 필드
        public string LastName { get; set; }//Table 상 필드

        string email;//Table 상 필드

        public string Email
        {
            get { return email; }
            set
            {
                if (Commons.IsValidEmail(value))
                    email = value;
                else
                    throw new Exception("Invalid Email");
            }
        }

        DateTime date;//Table 상 필드
        public DateTime Date
        {
            get { return date; }
            set
            {
                var result = Commons.CalcAge(value);//나이
                if (result > 150 || result < 0) throw new Exception("Incalid Age");
                else date = value;
            }
        }

        public Person(string firstName, string lastName, string email, DateTime date)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Date = date;
        }

        public bool IsBirthDay//추가 속성
        {
            get {
                return DateTime.Now.Month == Date.Month &&
                  DateTime.Now.Day == Date.Day;
            }
        }

        public string ChnZodiac
        {
            get
            {
                return Commons.GetChineseZodeiac(Date);
            }
        }

        public bool Isadult
        {
            get
            {
                return Commons.CalcAge(Date) > 18;
            }
        }
    }
}
