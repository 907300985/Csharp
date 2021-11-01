using System;
using Tools;

namespace HelloLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            double result = Calculator.add(3, 4);
            double result1 = Calculator.sub(3, 4);
            double result2 = Calculator.mul(3, 4);
            double result3 = Calculator.div(3, 0);
            Console.WriteLine(result3);

        }
    }
}
