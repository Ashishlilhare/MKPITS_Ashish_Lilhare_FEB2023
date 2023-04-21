using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heirarchical_inheritance__2
{
    public class Person
    {
        String name;
        String address;
        public void getPersonData(String name, String address)
        {
            this.name = name;
            this.address = address;
        }
        public void displayPersonData()
        {
            Console.WriteLine("name : " + name);
            Console.WriteLine("address : " + address);

        }
    }

    public class Student : Person
    {

        int rno;
        int marks;
        public void getStudentData(int rno, int marks)
        {
            //   getPersonData("arifa", "nagpur"); //calling base class method from derieved class
            this.rno = rno;
            this.marks = marks;
        }
        public void displayStudentData()
        {
            //  displayPersonData(); //calling base class method from derieved class
            Console.WriteLine("rno : " + rno);
            Console.WriteLine("marks : " + marks);

        }
    }
    public class Employee : Person
    {
        int salary;
        String designation;
        public void getEmployeeData(int salary, String designation)
        {
            //   getPersonData("arifa", "nagpur"); //calling base class method from derieved class
            this.salary = salary;
            this.designation = designation;
        }
        public void displayEmployeeData()
        {
            //  displayPersonData(); //calling base class method from derieved class
            Console.WriteLine("salary : " + salary);
            Console.WriteLine("designation : " + designation);

        }
    }

    class TestInheritance
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-----------------student-----------------");
            //creating object of student class
            Student p1 = new Student();//creating object of child class\
            p1.getPersonData("Ashish", "nagpur");
            p1.getStudentData(128, 8777);
            p1.displayPersonData();
            p1.displayStudentData();

            Console.WriteLine("-----------------Employee-----------------");
            //creating object of employee class
            Employee e1 = new Employee();
            e1.getPersonData("michale", "nagpur");
            e1.getEmployeeData(25000, "manager");
            e1.displayPersonData();
            e1.displayEmployeeData();
            Console.ReadLine();



        }
    }

}

