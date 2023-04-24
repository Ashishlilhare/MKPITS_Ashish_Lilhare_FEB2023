using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array.sort_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 3, 5, 7, 2, 12, 43, 1, 9, 51 };
            Array.Sort(num);


            //For display array
            for (int i = 0; i < num.Length; i++) 
            {
                Console.Write(num[i]+"\t");
            }
            Console.ReadLine();
        }
    }
}
