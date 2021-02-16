namespace code_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Book book = new Book();
            // book.Id = 1;
            // book.Name = "计算机基础";
            // book.Price = 34.5;
            book.SetBook(1, "计算机基础", 34.5);
            book.PrintMsg();
        }
    }
}
