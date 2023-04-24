using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method__with_parameter_and_not_returning_value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter number 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Calling addition method");
           addition(num2,num1);
            Console.WriteLine("calling substraction method");
           substraction(num2,num1);  
            Console.ReadKey();
        }
        static void addition(int n1,int n2) 
        {
        int result=n1+ n2;
            Console.WriteLine("addition=" + result);
        }
        static void substraction(int n1, int n2)
        {
            int result = n1 - n2;
            Console.WriteLine("substraction=" + result);
        }
    }
}
