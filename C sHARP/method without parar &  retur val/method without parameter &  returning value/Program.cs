using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_without_parameter____returning_value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("calling the method ");
            int result = calculatesquare();
            Console.WriteLine("square=" + result);
            Console.ReadKey();

        }
        static int calculatesquare()

            {
                int num;
                Console.WriteLine("enter number");
                num=Convert.ToInt32(Console.ReadLine());
                int square = num * num;
                return square;
               
            }
        
    }
}
