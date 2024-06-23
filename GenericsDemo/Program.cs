namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var books=new BookList();
            books.Add(new Book());

            var numbers=new NumberList();
            numbers.Add(10);

            var numbers1=new GenericList<int>();
            numbers1.Add(1);

            var books1=new GenericList<Book>();
            books1.Add(new Book());

            var dictionary=new GenericDictionary<string,Book>();
            dictionary.Add("1234",new Book());
        }
    }
}
