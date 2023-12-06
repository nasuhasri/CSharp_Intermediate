
using System;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();

            var order = new Order();
            customer.Orders.Add(order);

            // if we didnt add constructor class, C# will auto make it for use

            Console.WriteLine(customer.Id); // default value by C# - 0
            Console.WriteLine(customer.Name); // default value by C# - null4

            UsePoints();

            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(new int[] {1, 2, 3, 4, 5}));
        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(new Point(40, 60));
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
            }
            catch (Exception)
            {

                Console.WriteLine("An unexpected error occur.");
            }
        }
    }
}
