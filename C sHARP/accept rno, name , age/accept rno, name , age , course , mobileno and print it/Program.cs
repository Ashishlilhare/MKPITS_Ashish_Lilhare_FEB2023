using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accept_rno__name___age___course___mobileno_and_print_it
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1,num2;
            double mobile;

            Console.WriteLine("please enter Your Roll number");
            num1 = Convert.ToInt32(Console.ReadLine());
                        
            Console.WriteLine("please enter your name ");
            string name,course;
            name = Console.ReadLine();
            Console.WriteLine("please enter Your Age");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter your course ");
            course = Console.ReadLine();
            
            
            Console.WriteLine("please enter your mobile number ");
            mobile = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Roll no= " + num1);
            Console.WriteLine("name= " + name);
            Console.WriteLine("Age= " + num2);
            Console.WriteLine("Course= " + course);
            Console.WriteLine("mobile no= " + mobile);
            Console.ReadKey();
        }
    }
}
