using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube_function__recursion
{
    internal class Program
    {
        static void Main( )
        {
            int cube = myfunct(5, 3);
            Console.WriteLine(cube);
            Console.ReadLine();
        }
        static int myfunct(int x, int y) 
        { 
         if (y<=0)
            {
                return 1;
            }
         else
            {
                return x * myfunct(x,y-1);
            }
        }
    }
}
