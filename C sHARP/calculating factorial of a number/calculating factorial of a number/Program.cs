using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculating_factorial_of_a_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, result;
            Console.WriteLine("Please enter number");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("calling factorial function");
            result = Factorial(num); // calculates 5! = 5 x 4 x 3 x 2 x 1 = 120
            Console.WriteLine("Factorial = " + result); // prints 120
            Console.ReadKey();
        }
        static int Factorial(int n)
        {
            if (n == 10)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
    }
}
