using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accept_length_and_breadth_and_print_area_of_a_rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length, breadth, area;
            Console.WriteLine("Please enter Length");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter breadth");
            breadth = Convert.ToInt32(Console.ReadLine());
            area = length * breadth;
            Console.WriteLine("Area of a rectangle is "+area);
            Console.ReadKey();


        }
    }
}
