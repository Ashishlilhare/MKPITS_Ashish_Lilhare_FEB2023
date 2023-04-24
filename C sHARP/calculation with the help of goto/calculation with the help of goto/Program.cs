using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculation_with_the_help_of_goto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result = 0;
            Char op;
            Console.WriteLine("Enter 1st number ");
           num1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            num2= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter '+','-','*'");
            op=Convert.ToChar(Console.ReadLine());

            if (op == '+')
            {
                goto addition;
            }
            else if (op == '-')
            {
                goto substraction;
            }
            else if (op == '*') ;
            {
                goto multiplication;
            }
            addition:
            result = num1 + num2;
            goto end;
                
            substraction:
            result = num1 - num2;
            goto end;
            multiplication:
            result = num1 * num2;
            goto end;

        end:
            Console.WriteLine("result=" + result);
            Console.ReadKey();


        }
    }
}
