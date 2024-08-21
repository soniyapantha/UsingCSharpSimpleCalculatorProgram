using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x1;
            int x2;
            int result;
            string compute;
            Console.WriteLine("Hello welcome to the calculator program");
            Console.WriteLine("Please enter your first number");

            x1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your second number");
            x2= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What type of operation would you like to do");
            Console.WriteLine("Please enter a for addition,s for substraction,m for multiplication, and d for division");

            compute = Console.ReadLine();

            if(compute == "a")
            {
                result=x1 + x2;
            }
            else if(compute =="s")
            {
                result = x1 - x2;
            }
            else if(compute=="m")
            {
                result = x1 * x2;
            }
           
            else
            {
                result= x1/x2;
            }
            Console.WriteLine("The result is "+result);
            Console.WriteLine("Thankyou for using the calculator program done by Soniya Pantha!");
            Console.ReadKey();

        }
    }
}
