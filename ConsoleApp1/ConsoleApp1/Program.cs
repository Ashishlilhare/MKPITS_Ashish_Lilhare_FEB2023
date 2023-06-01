using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //public class Person
    //{
    //    private string name;
    //    private int age;

    //    public string Name
    //    {
    //        get { return name; }
    //        set { name = value; }
    //    }

    //    public int Age
    //    {
    //        get { return age; }
    //        set
    //        {
    //            if (value < 0)
    //            {
    //                Console.WriteLine("please enter age in +ve");
    //            }
    //            age = value;
    //        }
    //    }
    //        class program
    //    {
    //        public static void Main(string[] args) 
    //        {
    //        Person p=new Person();
    //            p.name = "ashish";
    //            p.Age = -30;
    //            Console.WriteLine(p.Name);
    //            Console.WriteLine(p.Age);
    //            Console.ReadLine();
    //        }
    //    }
    //    }
    class Student
    {
        // Creating setter and getter for each property  
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            // Setting values to the properties  
            student.ID = "101";
            student.Name = "Mohan Ram";
            student.Email = "mohan@example.com";
            // getting values  
            Console.WriteLine("ID = " + student.ID);
            Console.WriteLine("Name = " + student.Name);
            Console.WriteLine("Email = " + student.Email);
            Console.ReadLine();
        }
    }
}


