using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Time
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Green; // make green text
            Console.WriteLine("_____DATE_____");
            Console.ResetColor();

            ///<summary>
            ///create object dateTime with param
            ///</summary>
            DateTime date= new DateTime(2022,1,20,13,05,20);
            Console.WriteLine($"{date.ToString("d")}");
            Console.WriteLine($"{date.ToString("D")}");
            Console.WriteLine($"{date.ToString("Y")}");
            Console.WriteLine($"{date.ToString("ddd:d:MMM:yyyy")}");
            Console.WriteLine($"{date.ToString("dddd:d:MMM:yyyy")}");
            Console.WriteLine($"{date.ToString("d:MMM:yyyy")}");

            // Console.WriteLine(time / epoch time);

            Console.WriteLine();
            ///<summary>
            ///create object dateTime.Now
            ///</summary>>
            Console.WriteLine( DateTime.Now);// take date on pc
            Console.WriteLine(DateTime.UtcNow);//take date Gmt
            Console.WriteLine( DateTime.Today );//only today
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green; // make green text
            Console.WriteLine("_____TIme_____");
            Console.ResetColor();
            ///<summary>
            ///create timeline
            ///</summary>>
            Console.WriteLine(date.ToLongTimeString());
            Console.WriteLine(date.ToShortTimeString());
            Console.WriteLine(date.ToString("hh:mm:s"));
           

            Console.ForegroundColor = ConsoleColor.Green; // make green text
            Console.WriteLine("_____DayTime_____");
            Console.ResetColor();
            ///<summary>
            ///create 
            ///</summary>>
            Console.WriteLine(DateTimeOffset.UtcNow);
            Console.WriteLine(date.ToString("g"));
            Console.WriteLine(date.ToString("d MMMM yyyy H:mm:s"));
            Console.WriteLine(date.ToString("R"));
            Console.WriteLine(date.ToString("s"));

            Console.WriteLine("Enter x");
            int x=int.Parse(Console.ReadLine());
            DateTime d1 = DateTime.Now.AddYears(-x);
            Console.WriteLine("U was born"+d1.ToString(" yyyy"));

            Console.WriteLine("Enter d");
            int d = int.Parse(Console.ReadLine());
            DateTime d2 = DateTime.Now.AddYears(-d);
            Console.WriteLine("Ur age" + d2.ToString(" yyyy"));


            Console.ReadKey();
        }
    }
}
