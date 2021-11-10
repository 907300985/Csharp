using System;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace TestReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //ITank tank = new HeavyTank();
            //================分割线=================
            /*            直接使用反射
             *          var t = tank.GetType();
                        object o = Activator.CreateInstance(t);
                        MethodInfo fireMi = t.GetMethod("Fire");
                        MethodInfo runMi = t.GetMethod("Run");

                        fireMi.Invoke(o, null);
                        runMi.Invoke(o, null);*/

            /*
             DI依赖注入
             依赖反转:概念,创建接口形成倒关系*/

            var sc = new ServiceCollection();
            sc.AddScoped(typeof(ITank), typeof(HeavyTank));
            sc.AddScoped(typeof(IVehicle), typeof(LightTank));
            sc.AddScoped<Driver>();
             var sp = sc.BuildServiceProvider();
            //=====================================
            ITank tank = sp.GetService<ITank>();
            tank.Fire();
            tank.Run();
            //==========================================
            var driver = sp.GetService<Driver>();
            driver.Drive();
            
        }
    }

    class Driver
    {
        private IVehicle _vehicle;

        public Driver(IVehicle vehicle)
        {
            _vehicle = vehicle;
        }
        public void Drive()
        {
            _vehicle.Run();
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
