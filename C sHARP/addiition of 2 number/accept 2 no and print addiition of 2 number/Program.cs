using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accept_2_no_and_print_addiition_of_2_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, Addition;
            Console.WriteLine("Please enter num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter num2");
           
            num2 = Convert.ToInt32(Console.ReadLine());
            Addition = num1 + num2;
            Console.WriteLine("Addition of both the Number is "+Addition);
            Console.ReadKey();
        }
    }
}
