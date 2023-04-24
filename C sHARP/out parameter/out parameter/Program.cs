using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pass_by_refremce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int radius;
            float area, cir;
            Console.WriteLine("enter th radius");
            radius = Convert.ToInt32(Console.ReadLine());
            
            Calculatearea(radius, out area, out cir);
            Console.WriteLine("area= " + area);
            Console.WriteLine("circumference= " + cir);
            Console.ReadLine();
        }
        static void Calculatearea(int r,
                                  out float a,
                                  out float c)
        {
            a = 3.14f * r * r;
            c = 2 * 3.14f * r;

        }
    }
}
