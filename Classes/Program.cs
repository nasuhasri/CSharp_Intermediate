
using System;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            Console.WriteLine(customer.Orders.Count);
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

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5 }));
        }
    }
}
