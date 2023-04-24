using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check_prime_number_with_one_parameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num,Counter,isprime=0;
            Console.WriteLine("Please enter number");
            num = Convert.ToInt32(Console.ReadLine());
            for (Counter=2;Counter<num;Counter++) 
            {
            if(num%Counter == 0) 
                {
                    isprime = 1;
                    break;
                }
            }
            if (isprime==0)
            {
                Console.WriteLine(num + " is prime");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine(num + " is not prime");
                Console.ReadKey();
            }
        }
         
    }
}
