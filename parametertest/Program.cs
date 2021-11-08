using System;

namespace parametertest
{
    class Program
    {
        static void Main(string[] args)
        {
            //printinfo("Tim", 34);
            printinfo( age: 34, name: "Tim");
        }

        private static void printinfo(string name, int age)
        {
            Console.WriteLine("Hello {0},you are {1}", name, age);
        }
    }
}
