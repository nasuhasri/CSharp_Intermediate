namespace Association
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var rating = CalculateRating(excludeOrders: true);

            if (rating == 0)
            {
                System.Console.WriteLine("Promoted to Level 1");
            }
            else
            {
                System.Console.WriteLine("Promoted to Level 2");
            }
        }

        // put this as private bcs we want to minimize the public interface of a class to the outside
        // let say, in main method, the object able to access this method and the method implementation changing ie params,
        // we have to refactor the code. it will become troublesome if there are 10 other places that call this method.
        private int CalculateRating(bool excludeOrders)
        {
            return 0;
        }
    }
}
