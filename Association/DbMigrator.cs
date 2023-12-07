namespace Association
{
    public class DbMigrator
    {
        // this how composite class looks - simple take another class as a private field
        private readonly Logger _logger;

        public DbMigrator(Logger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.Log("We are migration...");
        }
    }
}
