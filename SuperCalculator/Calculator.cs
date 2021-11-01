using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public class Calculator
    {
        public static double add(double a, double b)
        {
            return a + b;
        }

        public static double sub(double a, double b)
        {
            return a - b;
        }
        public static double mul(double a, double b)
        {
            return a * b;
        }
        public static double div(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error");
            }
            return a / b;
        }
    }
}
