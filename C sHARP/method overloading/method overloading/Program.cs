//example of method overloading with different no. of parameters
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_overloading
{
    class employee
    {
        int empno;
        string empname;
        public void getdata (int empno) 
        {
         this.empno = empno;
            this.empname = "ashu";

        }
        // Method overloading

        public void getdata(int empno,string empname)
        {
        this.empno = empno;
        this.empname = empname;
        }
        public void display()
        {
          Console.WriteLine("empno "+ empno);
            Console.WriteLine("empname " + empname);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            employee emp = new employee();
            emp.getdata(134);
            emp.display();

            emp.getdata(44,"ashish");
            emp.display();
            Console.ReadLine();
        }
    }
}
