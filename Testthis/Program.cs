using System;

namespace Testthis
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 3.14159;
            double y = x.Round(4);
            Console.WriteLine(y);

        }
    }

    static class DoubleExtension
    {
        //this扩展方法，将传入的第一个参数变成调用者
        public static double Round(this double input, int digits)
        {
            double result = Math.Round(input, digits);
            return result;
        }
    }
}
