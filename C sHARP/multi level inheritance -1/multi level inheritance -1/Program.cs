using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multi_level_inheritance__1
{
    public class Animal
    {
        public void eat() { Console.WriteLine("Eating..."); }
    }
    public class Dog : Animal
    {
        public void bark() { Console.WriteLine("Barking..."); }
    }
    public class BabyDog : Dog
    {
        public void weep() { Console.WriteLine("Weeping..."); }
    }
    class TestInheritance2
    {
        public static void Main(string[] args)
        {
            BabyDog d1 = new BabyDog();
            d1.eat();
            d1.bark();
            d1.weep();
            Console.ReadLine();
        }
    }
}
