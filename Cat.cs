using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    class Cat
    {
        public string name;
        public int age;
        public bool isPersian;
        public Cat sibling;

        public Cat(string name, int age, bool isPersian)
        {
            this.name = name;
            this.age = age;
            this.isPersian = isPersian;
        }

        public void Overview() {
            Console.WriteLine(this.name + " is a Cat");
            if (isPersian)
                Console.WriteLine(this.name + " is a Persian Cat");
            else
                Console.WriteLine(this.name + " is not a Persian Cat");

            Console.WriteLine(this.name + " is " + age.ToString() + " years old");
        }
        /// <summary>
        /// use <code>object o = cat1+cat2;</code> to use this operation
        /// </summary>
        public static object operator +(Cat cat1, Cat cat2)
        {
            Console.WriteLine(cat1.name + " is now siblings with " + cat2.name);
            cat1.sibling = cat2;
            cat2.sibling = cat1;
            return null;
        }
        /// <summary>
        /// use <code>object o = cat1-cat2;</code> to use this operation
        /// </summary>
        public static object operator -(Cat cat1, Cat cat2)
        {
            Console.WriteLine(cat1.name + " is no longer siblings with " + cat2.name);
            cat1.sibling = null;
            cat2.sibling = null;
            return null;
        }
        public void Age(Cat catin, int increase)
        {
            catin.age = catin.age + increase;
        }
    }
}
