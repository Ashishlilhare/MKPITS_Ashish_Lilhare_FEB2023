using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finnaly_exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10;
            int n2 = 0;
            int res = 0;
            try 
            {
                res = n1 / n2;
                Console.WriteLine("result = " + res);
            }
            catch(DivideByZeroException ee)
            {
            Console.WriteLine(ee.ToString());
            }
            finally
            {
                Console.WriteLine("finally executed");

            }
            Console.WriteLine("bye");
            Console.ReadLine();
        }
    }
}
