using System;

class Program
{
    static void Main(string[] args)
    {
        // First Order
        Address addressOne = new Address("34 East Ave", "Rexburg", "Idaho", "USA");
        Customer customerOne = new Customer("Abby", "Shields", addressOne);
        Order orderOne = new Order(customerOne);
        orderOne.addProduct(new Product("Peanut BUtter Sauce", 903489, 138, 10));
        orderOne.addProduct(new Product("Toe Squeegee", 58239, 59.99, 3));
        orderOne.addProduct(new Product("Tee", 5, 0.99, 3));
        // Order two
        Address addressTwo = new Address("175 w 5th S", "Rexburg", "Idaho", "USA");
        Customer customerTwo = new Customer("Pizza", "Bob", addressTwo);
        Order orderTwo = new Order(customerTwo);
        orderTwo.addProduct(new Product("Yellow Mustard", 3, 2.99, 6));
        orderTwo.addProduct(new Product("Green Apple", 4, 3.99, 2));
        // Order three
        Address addressThree = new Address("1234 West Lime Ave", "Rexburg", "Idaho", "Nigeria");
        Customer customerThree = new Customer("Pizza", "Bob", addressThree);
        Order orderThree = new Order(customerThree);
        orderThree.addProduct(new Product("Halle", 1, 58.75, 3));
        orderThree.addProduct(new Product("Sauce", 11, .25, 111));

        Console.WriteLine("Order one");
        Console.WriteLine(orderOne.getPacking());
        Console.WriteLine(orderOne.getShipping());
        Console.WriteLine($"Your shipping cost is {orderOne.getShippingCost()}$");
        Console.WriteLine($"Your TOtal cost is {orderOne.getTotal()}$");

        Console.WriteLine("\nOrder Two");
        Console.WriteLine(orderTwo.getPacking());
        Console.WriteLine(orderTwo.getShipping());
        Console.WriteLine($"Your shipping cost is {orderTwo.getShippingCost()}$");
        Console.WriteLine($"Your TOtal cost is {orderTwo.getTotal()}$");

        Console.WriteLine("\nOrder Three");
        Console.WriteLine(orderThree.getPacking());
        Console.WriteLine(orderThree.getShipping());
        Console.WriteLine($"Your shipping cost is {orderThree.getShippingCost()}$");
        Console.WriteLine($"Your TOtal cost is {orderThree.getTotal()}$");

        



    }
}