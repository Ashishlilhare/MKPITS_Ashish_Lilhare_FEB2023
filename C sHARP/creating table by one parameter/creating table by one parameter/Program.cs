using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creating_table_by_one_parameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Please enter number");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("calling table function");
            table(num);
            Console.ReadKey();
        }

        static void table(int num)
        {
            for (int i = 1; i <= 10; i++)
            {
                int result = num * i;
                Console.WriteLine(num + " x " + i + " = " + result);
            }
        }
    }
}