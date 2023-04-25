using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealed_method
{
    class person
    {
        public virtual void display()
        {
            Console.WriteLine("hello from person");
        }
    }
    class student : person 
    {
        public sealed override void display()
        {
          Console.WriteLine("hello from student");
        }
    }
        class paststudent:student
        {
        public static void Main display()
        {
            Console.WriteLine("here from past time");
        }

    }

}
