using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace account
{
        class account
        {
            public int balance=1000;
            public virtual void deposit (int amt)
            {
                Console.WriteLine("deposited method of account class");

            }
        }
        class saving:account
        {
            int interest = 500;
            public override void deposit(int amt)
            {
                balance=balance+interest+amt;
                Console.WriteLine("deposited balance is " + balance);
                Console.ReadLine();
            }
        }
        class current : account
        {
            public override void deposit(int amt)
            {
                balance = balance + amt;
                Console.WriteLine("deposited balance is " + balance);
                Console.ReadLine();
            }
        }
    class program
    {
        public static void Main( ) 
        {
            int amount;
            Console.WriteLine("Enter Amount");
            amount = Convert.ToInt32(Console.ReadLine());
            account act = null;
            String acttype;
            Console.WriteLine("Enter Account Type Saving or Current ");
            acttype = Console.ReadLine();
            if (acttype == "saving")
            { 
            act=new saving();
            }
            else if(acttype =="current")
            {
                act=new current();
            }
            act.deposit(amount);
            
        }
    }
}
