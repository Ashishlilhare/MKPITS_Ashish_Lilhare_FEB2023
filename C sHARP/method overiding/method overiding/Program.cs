using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_overiding
{
    class account
    {
        public int balance = 1000;
        public void deposit(int amount) 
        {
            Console.WriteLine("deposite method of account class");
            Console.ReadLine();
        }
    }
    class saving : account
    {
        int interest = 500;

        public void deposit(int amt)
        {
            balance = balance + amt + interest;
            Console.WriteLine("deposite balnce is " + balance);
            Console.ReadLine();
        }
    }
    class program 
    {
        public static void Main( )
        {
            saving s= new saving();
            s.deposit(200);
        }
    }
    
}
