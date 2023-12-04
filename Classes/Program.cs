
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
            Console.WriteLine(customer.Name); // default value by C# - null
        }
    }
}
