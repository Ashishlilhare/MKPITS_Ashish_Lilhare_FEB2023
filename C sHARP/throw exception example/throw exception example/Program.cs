using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace throw_exception_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            try
            {
                Console.Write("Enter your age ");
                age=Convert.ToInt32(Console.ReadLine());  
                if(age<=18 || age>50)
                {
                    throw new Exception("Enter age between 18 to 50");
                }
            else
                {
                    Console.WriteLine("Your age is " + age);
                }
             }
            catch (Exception ee)
            {
            Console.WriteLine (ee.ToString());
                Console.ReadLine();
            }
            Console.WriteLine("Bye");
            Console.ReadLine();
        }
    }
}
