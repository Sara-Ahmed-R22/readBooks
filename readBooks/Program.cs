namespace readBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BookstoreContext())
            {
                context.Database.EnsureCreated();


                Console.WriteLine("Books: " + context.Books.Count());
                Console.WriteLine("Authors: " + context.Authors.Count());
                Console.WriteLine("Categories: " + context.Categories.Count());
            }
        }
    }
}
