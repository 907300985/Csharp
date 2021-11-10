using System;

namespace TestOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle v1 = new RaceCar();
            Vehicle v = new Car();

            Action action = new Action(v1.Run);
            //action += v.Run;
            action.Invoke();

        }
    }
    class Vehicle { 
        public virtual void Run()
        {
            Console.WriteLine("父类我在跑");
        }
    }
    class Car: Vehicle
    {
        //public int Speed { get; set; }
        public override void Run()
        {
            //base.Run();
            Console.WriteLine("重写后的子类再跑");
        }
    }
    class RaceCar: Car
    {
        public override void Run()
        {
            Console.WriteLine("赛车正在跑");
        }
    }
}
