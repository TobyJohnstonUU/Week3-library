class Book
{
    String Title;
    String Author;
    String ISBN;


    public Book(string title, string author, string iSBN)
    {
        Title = title;
        Author = author;
        ISBN = iSBN;
    }

    void DisplayInfo()
    {
        Console.WriteLine($"Book Title: {Title}");
        Console.WriteLine($"Book Author: {Author}");
        Console.WriteLine($"Book ISBN: {ISBN}");
    }

    static void Main(String[] args)
    {
        Book book = new Book("C# for beginners", "BillGates", "12345678");

        book.DisplayInfo();
    }
}