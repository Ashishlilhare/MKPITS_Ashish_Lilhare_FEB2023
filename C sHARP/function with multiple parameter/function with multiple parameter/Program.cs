using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function_with_multiple_parameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result;
            Console.WriteLine("enter number 1 ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number 2 ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Calling addition method");
            result = addition(num1, num2);
            Console.WriteLine("addition= " + result);
            Console.WriteLine("Calling substraction method");
            result = substraction(num1, num2);
            Console.WriteLine("substraction= " + result);
            Console.ReadLine();
            Console.ReadKey();
        }
        static int addition(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }
        static int substraction(int num1, int num2)
        {
            int result = num1 - num2;
            return result;
        }
    }
}
