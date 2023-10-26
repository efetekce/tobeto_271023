namespace Classes;

class Program
{
    static void Main(string[] args)
    {
        CustomerManager customerManager = new CustomerManager();
        customerManager.Add();
        customerManager.Update();
        ProductManager productManager = new ProductManager();
        productManager.Add();
        productManager.Update();


        Customer myCustomer = new Customer();
        myCustomer.City = "Istanbul";
        myCustomer.FirstName = "Efe";
        myCustomer.LastName = "Tekce";
        // when we're assigning values to properties, set method will work.
        Customer customer2 = new Customer
        {
            Id = 2,
            City = "Ankara",
            FirstName = "Efe"
        };

        Console.WriteLine(customer2.FirstName);
        // when we're reading values of properties as above, get method will work.
        Console.ReadLine();
    }
}



