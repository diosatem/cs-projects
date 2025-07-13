using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("123 Bickley Ave", "Thomastown", "Melbourne", "Australia");
         Customer customer = new Customer("Shoi", address);
      
        Console.WriteLine(customer.IsFromUSA());
    }
}