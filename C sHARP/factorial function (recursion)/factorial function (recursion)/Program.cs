using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial_function__recursion_
{
    internal class Program
    {
        public static void Main()
        {
            int fact, num;
            Console.Write("Enter num = ");
            num = Convert.ToInt32(Console.ReadLine());
            Program obj = new Program();
            fact = obj.factorial(num);
            Console.WriteLine("factorial of {0} is {1} ", num, fact);
            Console.ReadLine();
        }
        public int factorial(int num)
        {
        if (num == 0)
                return 1;
        else 
                return num*factorial(num-1);
        }
    }
}
