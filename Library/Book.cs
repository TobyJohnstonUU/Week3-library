

namespace Library
{
    internal class Book
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

        public void DisplayInfo()
        {
            Console.WriteLine($"Book Title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
        }
    }
}
