using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static_example;

namespace static_example
{
    public static class calculate
    {
        public static float pi = 3.14f;

        public static int cube(int n)
        {
            return n * n * n;

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pi = " + calculate.pi);
            Console.WriteLine("cube = " + calculate.cube(6));
        }
    }
}

