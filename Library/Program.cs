class Book
{
    String Title;
    String Author;
    String ISBN;

    void DisplayInfo()
    {
        Console.WriteLine($"Book Title: {Title}");
        Console.WriteLine($"Book Author: {Author}");
        Console.WriteLine($"Book ISBN: {ISBN}");
    }

    static void Main(String[] args)
    {
        Book book = new Book();

        book.Title = "C# for beginners";
        book.Author = "BillGates";
        book.ISBN = "12345678";

        Book book1 = new Book();

        book1.Title = "C# Methods and Classes";
        book1.Author = "Microsoft";
        book1.ISBN = "87654321";

        book.DisplayInfo();
        book1.DisplayInfo();
    }
}