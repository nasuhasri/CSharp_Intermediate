namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // cannot instantiate shape bcs it is abstract class
            //var shape = new Shape();

            var circle = new Circle();
            circle.Draw();

            var rectangle = new Rectangle();
            rectangle.Draw();
        }
    }
}
