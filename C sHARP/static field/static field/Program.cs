using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_field
{
    class account
    {
        public int actno;
        public string name;
        public static float roi=4.5f;
        public static int count;

        public account(int actno, string name)
        {
            this.actno = actno;
            this.name = name;
            count++;
        }
        public void display ()
        {
            Console.WriteLine("actno " + actno);
            Console.WriteLine("name " + name);
            Console.WriteLine("rate of Intrest "+roi);

            Console.ReadLine();
        }
    }
    class Program
    {
        public static void Main()
        {
            account a1 = new account(123,"MANISH");
            account a2 = new account(223, "ashish");

            account.roi = 33.4f;
            a1.display();
            a2.display();
            Console.WriteLine("no of objecet " + account.count);
            Console.ReadLine();

        }
    }
    
}
