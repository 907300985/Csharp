using System;

namespace TestDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            Action action = new Action(c.Report);

            c.Report();
            action();

            Func<int, int, int> func1 = new Func<int, int, int>(c.Add);
            Func<int, int, int> func2 = new Func<int, int, int>(c.Sub);

            int x = 100,y= 200, z=0;
            z = func1(x,y);
            Console.WriteLine(z);
            z = func2(x, y);
            Console.WriteLine(z);
        }
    }
    class Calculator
    {
        public void Report()
        {
            Console.WriteLine("I have 3 methods!");
        }

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }
    }
}
