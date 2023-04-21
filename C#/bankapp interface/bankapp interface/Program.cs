using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankapp_interface
{
    interface IAccount
    {
        string deposit(int amt);
    }
    abstract class Account: IAccount
    {
        public int balance = 1000;
        public abstract string deposit(int amt);
        public string showbalance()
        {
            return "bal is " + balance.ToString();
        }
    }
    class saving : Account
    {
        int interest = 500;
        public override string deposit(int amt) 
        {
        balance = balance+ amt+interest;
            return " amount deposited with interest bal is " + balance;

        }
    }
    class current : Account
    {
        public override string deposit(int amt) 
        {
            balance = balance + amt;
            return "amount deposited without interest bal is" + balance;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Account act = null;
            string acttype;
            Console.WriteLine("enter account type");
            acttype = Console.ReadLine();
            Console.WriteLine("enter amount to be ");
            int amount =Convert.ToInt32(Console.ReadLine());
            if(acttype=="saving")
            {
                act = new saving();

            }
            else if(acttype=="current")
            {
                act = new current();
            }
            string res =act.deposit(amount);
            Console.WriteLine(res);
            Console.WriteLine(act.showbalance());
            Console.ReadLine();
        }
    }
}
