using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    class Program
    {
        class Parent
        {
            public int variable = 273;
        }
        class Child : Parent
        {
            public string variable = "shadowing";
        }

        static void Main(string[] args)
        {
            Child child = new Child();
            Console.WriteLine(child.variable);
          	Console.WriteLine(((Parent)child).variable);
        }
    }
}
