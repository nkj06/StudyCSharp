using System;
using System.Globalization;
using static System.Console;

namespace StringSearch
{
    class Program
    {
        static void Main(string[] args)
        {

            //string g = "Good Morning, Good";
            //WriteLine(g);
            /*
            WriteLine($"IndexOF 'Good' : {g.IndexOf("Good")} ");
            WriteLine($"LastIndexOf 'Good' : {g.LastIndexOf("Good")}");

            WriteLine($"IndexOF 'n' : {g.IndexOf('n')}");
            WriteLine($"LastIndexOf 'n' : {g.LastIndexOf('n')}");

            // StartsWith
            WriteLine($"StartsWith 'Good' : {g.StartsWith("Good")}");
            WriteLine($"StartsWith 'Morning' : {g.StartsWith("Morning")}");

            // Contains
            WriteLine($"Contains 'Good' : {g.Contains("Good")}");

            // Replace
            WriteLine($"Replace 'Morning' to 'Evening' : " +
                $"{g.Replace("Morning", "Evening")}");

            if(g.Contains("Morning"))
            {
                g.Replace("Morning", "Evening");
            }

            WriteLine($"ToLower : {g.ToLower()}"); // 소문자
            WriteLine($"ToUpper : {g.ToUpper()}"); // 대문자
            WriteLine($"Insert : {g.Insert(g.IndexOf("Morning") - 1, " Very")}");

            WriteLine($"Remove : ' {"I don't Love You".Remove(2, 6)}'");
            WriteLine($"Trim : ' {"No Space ".Trim()}'");
            WriteLine($"Trim : ' {"No Space ".TrimStart()}'");
            WriteLine($"Trim : ' {"No Space ".TrimEnd()}'");
            */

            /*
            // 문자열 분할
            string codes = "MSFT,GOOG,AMZN,AAPL, RHT";
            var result = codes.Split(',');
            foreach(var item in result)
            {
                WriteLine($"each item {item}");
            }

            WriteLine($"substring : {g.Substring(0, 4)}");
            WriteLine($"substring : {g.Substring(5)}");
            */

            /*
            WriteLine(string.Format("{0}DEF", "ABC"));
            WriteLine(string.Format("{0,-10}DEF", "ABC"));
            WriteLine(string.Format("{0,10}DEF", "ABC"));
            */

           /*
           // 현재 시간
           DateTime dt = DateTime.Now;
           WriteLine(string.Format($"{dt:yyy-MM-dd HH:mm:ss}")); // 한국
           WriteLine(string.Format($"{dt:d/M/yyyy HH:mm:ss}")); // 미국
           WriteLine(string.Format($"{dt:y yy yyy yyyy}"));
           WriteLine(string.Format($"{dt:M MM MMM MMMM}"));
           WriteLine(string.Format($"{dt:d dd ddd dddd}"));

           WriteLine(dt.ToString("yyy-MM-dd HH:mm:ss", new CultureInfo("ko-KR")));
           WriteLine(dt.ToString("d/M/yyyy HH:mm:ss", new CultureInfo("en-US")));
           */

            // 돈
            decimal mvalue = 27000000m;
            WriteLine(string.Format("price {0:C}", mvalue));
            WriteLine(string.Format($"price {mvalue:C}"));

            WriteLine(mvalue.ToString("C", new CultureInfo("en-US")));
            WriteLine(mvalue.ToString("C", new CultureInfo("ko-KR")));
            WriteLine(mvalue.ToString("C", new CultureInfo("ja-JP")));
        }
    }
}