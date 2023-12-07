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
        }
    }
}
