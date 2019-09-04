using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double score;
            
            double testt = 0;
    
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter your test score");
                score = Convert.ToDouble(Console.ReadLine());



                testt = testt + score;
            }
            Console.WriteLine($"Final total of 3 tests is {testt}");
            double average;
            average = (testt / 3);
            Console.WriteLine($"Average of 3 tests is {average}");
            Console.ReadLine();


        }
    }
}
