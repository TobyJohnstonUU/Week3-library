using Library;

class Program
{
    static void Main(String[] args)
    {
        Book book = new Book("C# for beginners", "BillGates", "12345678");

        book.DisplayInfo();

        Member member = new Member(1, "John Doe", "No Address", 1);
    }
}
    