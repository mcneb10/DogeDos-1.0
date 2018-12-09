using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Animal
{
    class Doge
    {
        public string name;
        public int age;
        public bool isGoldenRetriever;
        public Doge sibling;
        public Doge(string name, int age, bool isGoldenRetriever)
        {
            this.name = name;
            this.age = age;
            this.isGoldenRetriever = isGoldenRetriever;
        }

        public void Overview()
        {
            Console.WriteLine(this.name + " is a Doge");
            if (isGoldenRetriever)
                Console.WriteLine(this.name + " is a Golden retriever");
            else
                Console.WriteLine(this.name + " is not a Golden retriever");

            Console.WriteLine(this.name + " is " + age.ToString() + " years old");
        }
        /// <summary>
        /// use <code>object o = doge1+doge2;</code> to use this operation
        /// </summary>
        public static object operator +(Doge doge1, Doge doge2)
        {
            Console.WriteLine(doge1.name + " is now siblings with " + doge2.name);
            doge1.sibling = doge2;
            doge2.sibling = doge1;
            return null;
        }
        /// <summary>
        /// use <code>object o = doge1-doge2;</code> to use this operation
        /// </summary>
        public static object operator -(Doge doge1, Doge doge2)
        {
            Console.WriteLine(doge1.name + " is no longer siblings with " + doge2.name);
            doge1.sibling = null;
            doge2.sibling = null;
            return null;
        }
        public void Age(Doge dogein, int increase)
        {
            dogein.age = dogein.age + increase;
        }
    }
}
