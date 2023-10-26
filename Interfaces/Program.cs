namespace Interfaces;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

interface IPerson
{
    int Id { get; set; }
    int FirstName { get; set; }
    int LastName { get; set; }
}

class Student : IPerson
{
    public int Id { get; set; }
    public int FirstName { get; set; }
    public int LastName { get; set; }
    public string address { get; set; }
}

class Instructor : IPerson
{
    public int Id { get; set; }
    public int FirstName { get; set; }
    public int LastName { get; set; }
    public string department { get; set; }
}
