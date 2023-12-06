using System.Collections.Generic;

namespace Classes
{
    public class Customer
    {
        public int Id;
        public string Name;
        // generic class that takes parameter so its called generic parameter
        // it represents list of object and the parameter (Order) specifies type of obj
        //public List<Order> Orders;

        // always intialize list with empty list
        public readonly List<Order> Orders = new List<Order>();


        public Customer()
        {
            // make sure that the list of object always initialized
            Orders = new List<Order>();
        }

        // call constructor w/o params first Customer() then, execute the rest of code
        public Customer(int id)
            : this()
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {
            Orders = new List<Order>();
        }
    }
}
