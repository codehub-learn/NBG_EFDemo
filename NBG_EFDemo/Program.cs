using NBG_EFDemo;

internal class Program
{
    public static void Main(string[] args)
    {
        Author eco = new Author() { FirstName = "Umberto", LastName = "Eco" };
        Book pendulum = new Book() { Title = "Foucault's Pendulum", PubDate = new DateTime(1998, 3, 15), Pages = 750, Author = eco}; //Do not initialize Id
        Book rose = new Book() { Title = "The Name of the Rose", PubDate = new DateTime(1980, 6, 11), Pages = 630, Author = eco };

        //using (BooksContext context = new BooksContext())
        //{
        //    context.Books.Add(pendulum);
        //    context.SaveChanges();
        //}

        using BooksContext context = new BooksContext();
        //context.Books.Add(pendulum);
        //context.Books.Add(rose);
        context.Books.AddRange(pendulum, rose);
        context.SaveChanges();
    }
}