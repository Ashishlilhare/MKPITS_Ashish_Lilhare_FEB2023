using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_of_an_3_element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];// for int
           // float[] arr = new float[3]; // for float
           // int[] arr = new int[3]; // for string
            arr[0] = 55555;
            arr[1] = 44444;
            arr[2] = 33333;


            //display the array element 
            foreach(int val in arr) 
            { 
            Console.WriteLine("num= "+val);
                Console.ReadLine();
            }
        }
    }
}
