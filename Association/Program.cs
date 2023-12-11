using System.Collections;
using System.Collections.Generic;

namespace Association
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var text = new Text();
            text.Width = 100;
            text.Copy();

            // composition
            var dbMigrator = new DbMigrator(new Logger());

            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.Migrate();
            installer.Install();

            // access modifier
            var customer = new Customer();

            // constructor inheritance
            // base class always executed first; Vehicle -> Car
            var car = new Car("XYZ123");

            // upcasting - both shape and text1 class pointing/references to the same object in memory
            // converting object reference to its base class reference
            Text1 text1 = new Text1();
            Shape shape = text1;

            text1.Width = 200;
            shape.Width = 100;

            System.Console.WriteLine(text1.Width); // return 100

            // this is not a good practice since the list contain a different type of elements
            var list = new ArrayList();
            list.Add(1);
            list.Add("Mosh");
            list.Add(new Text());

            // this is generic class that takes parameter which is int
            // every element must be in int type
            var anotherList = new List<int>();

            Shape shape1 = new Text1();
            Text1 text2 = (Text1) shape;
        }
    }
}
