using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    class Program
    {
        class MyMath
        {
            public static int Abs(int input)
            {
                if (input < 0)
                    return -input;
                else
                    return input;
            }
            public static double Abs(double input)
            {
                if (input < 0)
                    return -input;
                else
                    return input;
            }
            public static long Abs(long input)
            {
                if (input < 0)
                    return -input;
                else
                    return input;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(MyMath.Abs(52));
            Console.WriteLine(MyMath.Abs(-273));

            Console.WriteLine(MyMath.Abs(52.273));
            Console.WriteLine(MyMath.Abs(-32.103));

            Console.WriteLine(MyMath.Abs(2147483640));
            Console.WriteLine(MyMath.Abs(-2147483640));
        }
    }
}
