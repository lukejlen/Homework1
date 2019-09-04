using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participation9_4
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            //whatever the time is when this line runs
            DateTime future =  today.AddDays(26);
            DateTime future2 = today.AddHours(3).AddDays(27).AddMinutes(21);

            Console.WriteLine(today);
            Console.WriteLine(future);

            var difference = future - today;
            var difference2 = future2 - today;
            Console.WriteLine(difference.Days );
            Console.WriteLine(difference2);
            Console.ReadKey();
            
            File.readalllines
        }
    }
}
