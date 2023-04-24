using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "amit", "ram", "shyam" };
            foreach (string val in name) 
            {
            Console.WriteLine("name= "+ val );
                Console.ReadKey();
            }
        }
    }
}
