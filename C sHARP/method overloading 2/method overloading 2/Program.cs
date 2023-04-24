using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_overloading_2
{
    internal class Program
    {
        class employee
        {
            int empno;
            string empname;

            public void getdata(string empname, int empno)
            {
                this.empno = empno;
                this.empname = "ashu";
            }
            //overloading method
            public void getdata(int empno, string empname)
            {
                this.empno = empno;
                this.empname = empname;
            }
            public void display()
            {
                Console.WriteLine("empno " + empno);
                Console.WriteLine("empname " + empname);
            }
        }
        class program
        {
            static void Main(string[] args)
            {
                employee emp = new employee();
                emp.getdata("ashu", 55);
                Console.WriteLine("------------------------employeee 1 details :------------------------");
                emp.display();

                employee emp1 = new employee();
                emp1.getdata(77, "rahul");
                Console.WriteLine("------------------------employeee 2 details :------------------------");
                emp1.display();
                Console.ReadLine();
            }
        }
    }
}
