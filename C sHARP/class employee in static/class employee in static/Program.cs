using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_employee_in_static
{
    class employee
    {
        public int empno;
        public string name;
        public static string companyname="WILCRAFT";

        public employee(int empno, string name)
        {
            this.empno = empno;
            this.name = name;
        }
        public void display()
        {
            Console.WriteLine("Company name = "+companyname);
            Console.WriteLine("Employee ID = "+empno);
            Console.WriteLine("Employee Name = "+name);
            Console.ReadLine();
        }
    }
     class Program
    {
        public static void Main(string[] args)
        {
            
            

            employee e1 = new employee(43432, "Ashish");
            employee e2 = new employee(7776, "Aaysha");
            employee e3 = new employee(6565,"Prashu");
            e1.display();
            e2.display();
            e3.display();
            //for user input
            //int empno;
            //Console.Write("Enter Employee ID = ");
            //empno = Convert.ToInt32(Console.ReadLine());
            //string name;
            //Console.Write("Enter name = ");
            //name = Console.ReadLine();
        }
    }
}
