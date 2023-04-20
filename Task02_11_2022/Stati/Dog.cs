using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02_11_2022.Stati
{
    internal class Dog
    { 
        internal static int Count = 0;

        internal string Name { get; set; }
        internal void Say()
        {
            Console.WriteLine("qwert");
        }
        internal static float Do(float a)
        {
            return a + 5.0f;
        }

        internal Dog(string name)
        {
            Name = name;
            Count++;
        }
        static Dog()
        {
            Count = 0;
        }
    }
}
