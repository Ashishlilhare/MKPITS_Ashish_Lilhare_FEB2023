using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hierarchical_inheritance__1
{
    class person
    {
        public string name;
        public string address;
    }
    class student : person 
    {
        public int rno;
        public int marks;
    }
    class employee : person
    {
        public int salary;
        public string designation;
    }
    class program
    { 
        static void Main(string[] args)
        {
            // creating object of Student

            student s = new student();
            s. name = "Ashu";
            s.address = "Nagpur";
            s.rno = 64;
            s.marks = 899;

            Console.WriteLine("---------------student detail-----------------");
            Console.WriteLine("name :" + s.name);
            Console.WriteLine("address :" +s.address );
            Console.WriteLine("r.no :" + s.rno);
            Console.WriteLine("mark :" + s.marks);

            // creating object of employee
            employee emp= new employee();
            emp.name = "Ashish";
            emp.address = "Nagpur";
            emp.salary = 65000;
            emp.designation = "Analyst";

            Console.WriteLine("---------------Employee detail-----------------");
            Console.WriteLine("name :" + emp.name);
            Console.WriteLine("address :" + emp.address);
            Console.WriteLine("salary :" + emp.salary);
            Console.WriteLine("designation :" + emp.designation);

            Console.ReadLine();
        }
    }
}
