using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops2
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 0; //placeholder
            double score;
            string question;
            double accumulation = 0;

            do
            {

                Console.WriteLine("Enter your test score");
                score = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Do you want to enter another exam score? Answer 'yes' if so...");
                question = Convert.ToString(Console.ReadLine());

                
                accumulation = accumulation + score;
                i++;
             }
            while (question == "yes" || question == "Yes");


            double average = (accumulation / i);
            Console.WriteLine($"Your average is {average}, based off of {i} exam scores");
            Console.ReadLine();

        }
    }
}



