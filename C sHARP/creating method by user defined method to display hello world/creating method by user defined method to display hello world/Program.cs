using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creating_method_by_user_defined_method_to_display_hello_world
{
    internal class Program
    {
        static void Main(string[] args)
            {
             Console.WriteLine("calling the method display");
                display();
            Console.ReadKey();
            }
            //creating user defined method display
            static void display() 
            {
            Console.WriteLine("hello world");

            }
         
    }
}
