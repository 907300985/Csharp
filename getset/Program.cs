using System;

namespace getset
{
    class Program
    {
        static void Main(string[] args)
        {
            People p = new People();
            p.h = 10;
            p.Age = 100;
            Console.WriteLine(p.h);
            Console.WriteLine(People.love);

        }
    }
    class People
    {
 
        public int h{ get; set; }
        public int w{ get; set; }
        public int Age { get => age; set => age = value; }

        private int age;
        public  const int love = 3000;
        
    }
}
