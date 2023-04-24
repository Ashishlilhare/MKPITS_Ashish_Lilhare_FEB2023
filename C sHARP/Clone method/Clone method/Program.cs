using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clone_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = {1, 2, 3, 4, 5, 6, 7};
            int[] num1= (int[]) num.Clone();

            for (int i= 0; i<num1.Length; i++)
            {

                Console.Write(num1[i] +"\t");
                
            }
            Console.ReadLine();
        }
        
    }
}
