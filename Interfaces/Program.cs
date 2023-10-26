﻿namespace Interfaces;

class Program
{
    static void Main(string[] args)
    {
        Manager manager = new Manager();
        Customer customer = new Customer { Id = 1, FirstName = "Efe", LastName = "Tekce", Address = "Istanbul" };
        manager.Add(customer);
        manager.Add(new Student() { Id = 2, FirstName = "ABC", Department = "HR" });
        manager.Add(new Worker());
    }
}

interface IPerson
{
    int Id { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
}

class Customer : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
}

class Student : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Department { get; set; }
}
class Worker : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Department { get; set; }
}

class Manager
{
    public void Add(IPerson person)
    {
        Console.WriteLine(person.FirstName);
    }
}