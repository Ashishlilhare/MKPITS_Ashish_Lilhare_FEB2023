using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accepting_3_no_and_print_addition_of_3_no
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1,num2,num3, addition;
            Console.WriteLine("please enter number 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter number 2");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter number 3");
            num3 = Convert.ToInt32(Console.ReadLine());
            addition=num1+num2+num3;
            Console.WriteLine("Addition of a number is " + addition);
            Console.ReadKey();
        }
    }
}
