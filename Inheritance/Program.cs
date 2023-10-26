namespace Inheritance;

class Program
{
    static void Main(string[] args)
    {
        Customer customer = new Customer();
        customer.FirstName = "Efe";

        Person[] persons = new Person[3]
        {
            new Customer{FirstName=".NET"},
            new Student{FirstName="React"},
            new Person{FirstName="1C"}
        };

        foreach (var person in persons)
        {
            Console.WriteLine(person.FirstName);
        }

    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    class Customer : Person
    {
        public string City { get; set; }
    }
    class Student : Person
    {
        public string Department { get; set; }
    }
}

