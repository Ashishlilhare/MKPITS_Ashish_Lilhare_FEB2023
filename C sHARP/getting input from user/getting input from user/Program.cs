using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getting_input_from_user
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");
            string name;
            name = Console.ReadLine();
            Console.WriteLine("hello my friend " + name);
            Console.ReadKey();
        }
    }
}
