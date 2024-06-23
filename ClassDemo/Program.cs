namespace ClassDemo;

class Program
{
    static void Main(string[] args)
    {
        //var person = Person.Parse("John");            
        //person.Introduce("Mosh");

        var customer = new Customer(1,"John");
        Console.WriteLine( customer.Id);
        Console.WriteLine(customer.Name);
    }
}