using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_example_2
{
    class perimeter
    {
        public enum shapes
        {
            circle,
            square
        }
        public void peri(int val, shapes s1)
        {
            //checking shape is circle or square
            if (s1==0)
            {
                //output for circumference
                Console.WriteLine("circumference of circle is " + 2*3.14*val);

            }
            else
            {
                //  else output the perimeter of the square
                Console.WriteLine("the perimeter of square is " + 4*val);
                Console.ReadLine();
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            perimeter p1= new perimeter();
            p1.peri(4,perimeter.shapes.circle);
            p1.peri(5, perimeter.shapes.square);
        }
    }
}
