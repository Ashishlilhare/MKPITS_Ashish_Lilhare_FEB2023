using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_example_1
{
    //creating enumerator month 
    enum month
    {
        //creating data member
        jan,
        feb,
        mar,
        april,
        may,
        jun,
        jul,
        aug,
        sep,
        oct,
        nov,
        dec
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("value of jan in enum is = " + (int)month.jan);
            Console.WriteLine("value of feb in enum is = " + (int)month.feb);
            Console.WriteLine("value of march in enum is = " + (int)month.mar);
            Console.WriteLine("value of april in enum is = " + (int)month.april);
            Console.WriteLine("value of may in enum is = " + (int)month.may);
            Console.WriteLine("value of june in enum is = " + (int)month.jun);
            Console.WriteLine("value of july in enum is = " + (int)month.jul);
            Console.WriteLine("value of august in enum is = " + (int)month.aug);
            Console.WriteLine("value of september in enum is = " + (int)month.sep);
            Console.WriteLine("value of octomber in enum is = " + (int)month.oct);
            Console.WriteLine("value of November in enum is = " + (int)month.nov);
            Console.WriteLine("value of december in enum is = " + (int)month.dec);
            Console.ReadLine();
        }
    }
}
