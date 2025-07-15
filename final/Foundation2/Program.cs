using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        //ORDER 1
        Address address1 = new Address("123 Bickley Ave", "Thomastown", "Melbourne", "Australia");

        Customer customer1 = new Customer("Shoi", address1);

        Product product1a = new Product("2.25\" Button Pin", "0001", 0.81f, 5);
        Product product1b = new Product("1.50\" Button Pin", "0002", 0.54f, 5);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1a);
        order1.AddProduct(product1b);

        order1.DisplayOrder();

        //ORDER 2
        Address address2 = new Address("97 Bernard St.", "Cheltenham", "Melbourne", "Australia");

        Customer customer2 = new Customer("Dona", address2);

        Product product2a = new Product("Letter Paper Colour Printing", "0003", 0.027f, 10);
        Product product2b = new Product("3R Photo Printing", "0002", 0.41f, 1);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2a);
        order2.AddProduct(product2b);

        order2.DisplayOrder();
    }
}