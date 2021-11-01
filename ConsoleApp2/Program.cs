using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("请输入你的数字：");
            int a = int.Parse(Console.ReadLine());
     
            Console.WriteLine("你的数字是:" + a);
          
            
            
            int sum = calulate(1, 2);
            //Console.WriteLine(sum);
            Animal cat = new Animal();
            //cat.eat();
            //cat.fly();
        }

        static int calulate(int a, int b)
        {
            return a + b;
        }

    }

    public interface fly
    {
        void fly();
    }

    public class Animal: Program, fly{
        
        public Animal()
        {
            Console.WriteLine("小动物吃都行");
        }

       
        public void eat()
        {
            Console.WriteLine("小动物");
        }

   
        public void fly()
        {
            Console.WriteLine("我会飞");
        }
    }
}
