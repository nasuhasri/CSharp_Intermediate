
using System;

namespace Classes
{
    public class Person
    {
        public string Name;

        public void Introduce (string to)
        {
            Console.WriteLine("Hi {0}, I am {1}.", to, Name);
        }

        // create person object from string
        public Person Parse (string str)
        {
            var person = new Person ();
            person.Name = str;

            return person;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();

            // doesnt make sense, so we should put static keyword on Parse method
            // var p = person.Parse("John");
            // should be -> var person = Person.Parse("John")

            person.Name = "Nur";
            person.Introduce("Irfan");
        }
    }
}
