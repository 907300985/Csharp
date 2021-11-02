using System;

namespace TestConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Cal c = new Cal(1,"cat");
            Console.WriteLine(c.id);
            Console.WriteLine(c.name);
        }
    }


    class Cal
    {
        public int id;
        public String name;
        
        public Cal(int id, String name)
        {

        }
        public Cal()
        {
            this.id = 1;
            this.name = "nandi";
        }
    }
}
