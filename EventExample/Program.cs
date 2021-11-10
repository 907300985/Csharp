using System;

namespace EventExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Waiter waiter = new Waiter();
        }
    }
    public class OrderEventArgs
    {
        public string DishName { get; set; }
        public string Size { get; set; }
    }

    public delegate void OrderEventHandler(Customer customer, OrderEventArgs e);

    public class Customer
    {
        private OrderEventHandler orderEventHandler;

        public event OrderEventHandler Order
        {
            add
            {
                this.orderEventHandler += value;
            }
            remove
            {
                this.orderEventHandler -= value;
            }
        }
        
        public int Bill { get; set; }

        public void PayTheBill()
        {
            Console.WriteLine("I will pay $" + this.Bill);
        }
    }

    public class waiter
    {
        public void Action(Customer customer, OrderEventArgs e)
        {
            Console.WriteLine("I will serve you the dish -{0}",e.DishName);
            double price = 10;
            switch (e.Size)
            {
                case "small":
                    price *= 0.5;
                    break;
            }
        }
        Customer.Bill += price;
    }
}
