using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice__2
{
    internal class Program
    {
        //C# String Compare()

        static void Main(string[] args)
        {
            string s1 = "hello";
            string s2 = "hello1";

            int res = string.Compare(s1, s2);
            //   Console.WriteLine(res);
            if (res == 0)
                Console.WriteLine("both string are equal");
            else if (res == 1)
                Console.WriteLine("first string is greater");
            else
                Console.WriteLine("second string is greater");
            Console.ReadLine();
        }
    }
}
