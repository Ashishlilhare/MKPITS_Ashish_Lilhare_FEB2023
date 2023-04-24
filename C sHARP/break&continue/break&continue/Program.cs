using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace break_continue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            for(i=1; i<=10;i++)
            {
                if(i==5)
                {
                    //break;
                    continue;
                }
                Console.WriteLine("counter = " + i);
                Console.ReadKey();
            }
        }
    }
}
