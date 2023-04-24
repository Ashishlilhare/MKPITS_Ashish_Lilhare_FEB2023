using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double_Dimesional_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating a num array of 2 rows and 3 colums
            //   int[] num = new int[5] { 1, 2, 3, 4, 5 };

            int[,] num = { { 2, 2, 2 }, { 3, 3, 3 } };
            //display the values of array
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(num[i, j]+"\t");
                }
                Console.WriteLine();
            }
           //Syntax for cheking "rank","length " of the code.
            
            Console.WriteLine("rank " + num.Rank);
            Console.WriteLine("length " + num.Length);
            Console.ReadLine();

        }
    }
}
