using System;
using System.Reflection;

namespace TestReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            ITank tank = new HeavyTank();
            //================分割线=================
            var t = tank.GetType();
            object o = Activator.CreateInstance(t);
            MethodInfo fireMi = t.GetMethod("Fire");
            MethodInfo runMi = t.GetMethod("Run");

            fireMi.Invoke(o, null);
            runMi.Invoke(o, null);
        }
    }

    class Driver
    {
        //private ITank heavyTank;

        public Driver(IVehicle vehicle)
        {
            vehicle.Run();
        }
    }

    interface IVehicle
    {
        void Run();
    }

    class Car : IVehicle
    {
        public void Run()
        {
            Console.WriteLine("Car is running");
        }
    }

    class Truck : IVehicle
    {
        public void Run()
        {
            Console.WriteLine("Truck is running");
        }
    }

    interface IWeapon
    {
        void Fire();
    }

    interface ITank : IVehicle, IWeapon
    {

    }

    class LightTank : ITank
    {
        public void Fire()
        {
            Console.WriteLine("Boom!");
        }

        public void Run()
        {
            Console.WriteLine("ka ka ka...");
        }
    }

    class HeavyTank : ITank
    {
        public void Fire()
        {
            Console.WriteLine("Boom!!");
        }

        public void Run()
        {
            Console.WriteLine("ka! ka! ka!...");
        }
    }
}
