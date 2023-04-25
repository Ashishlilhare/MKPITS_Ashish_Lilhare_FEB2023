using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealed_class
{
    sealed class employee
    {
        public employee() 
        {
            Console.WriteLine("absabs");
        }
    }
    //    class pro:employee
    //{
        
    //}
    class program
    {
        public static void Main ()
    {
            employee emp = new employee();
            emp.ToString();
    }
    }

    
}
