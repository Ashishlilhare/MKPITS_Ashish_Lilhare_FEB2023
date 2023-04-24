using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accpeting_number_and_sq.it
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, square;
            Console.WriteLine("please enter the number");
            num = Convert.ToInt32(Console.ReadLine());
            square = num * num;
            Console.WriteLine("Square of the number is "+square);
            Console.ReadKey();
        }
    }
}
