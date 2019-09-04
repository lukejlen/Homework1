using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double cog = 79.99;
            double gear = 250.00;
            double markup = 1.15;
            double markup2 = 1.125;
            double salestax = .089;

            Console.WriteLine("How many cogs are you purchasing");
           int numberofcogs =    Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("How many gears are you purchasing");
            int numberofgears = Convert.ToInt32(Console.ReadLine());

            double cogprice;
            double gearprice;

            cogprice = numberofcogs * cog;
            gearprice = numberofgears * gear;
            double total;
            total = gearprice + cogprice;
            double endtotal;
            int totalnumber = numberofcogs+numberofgears;
            string  discountamount;


            if( totalnumber <16)
            {
                endtotal = total * markup;
                discountamount = "15%";
            }
            else if(numberofgears > 10)
            {
                endtotal = total * markup2;
                discountamount = "12.5%";
            }
            else if (numberofcogs > 10)
            {
                endtotal = total * markup2;
                discountamount = "12.5%";
            }
            else
            {
                endtotal = total * markup2;
                discountamount = "12.5%";

            }

            Console.WriteLine($"End total before tax = {endtotal}");
            Console.WriteLine($"Markup = {discountamount}");
            double tax = endtotal * (1 + salestax);
            Console.WriteLine($"End total after tax {tax}");
            Console.ReadLine();





        }
    }
}
