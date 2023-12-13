namespace Extensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            // from DBMigrator class, we can create ConsoleLogger and FileLogger (extends the application)
            var dbMigrator = new DbMigrator(new FileLogger("C:\\Users\\nasas\\source\\repos\\Classes\\log.txt"));
            dbMigrator.Migrate();
        }
    }
}
