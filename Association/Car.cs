using System;

namespace Association
{
    public class Car : Vehicle
    {
        //public Car()
        //{
        //    System.Console.WriteLine("Car is being intialized");
        //}

        public Car(string registrationNumber) 
            : base(registrationNumber)
        {
            Console.WriteLine("Car is being initialized. {0}", registrationNumber);
        }
    }
}
