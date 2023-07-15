using System;

class Program
{
    static void Main(string[] args)
    {
        Address addressOne = new Address("6 35th street", "birmingham", "alabama");
        DateTime dateOne = new DateTime(10, 10, 23);
        Lecture lecture = new Lecture("Love", "What does it mean to love? Come to this lecture to find out.", dateOne, addressOne, "Sister Johnson", 150);

        Address addressTwo = new Address("68 3rd street", "Rexburg", "Idaho");
        DateTime dateTwo = new DateTime(1,1,24);
        Gathering gathering = new Gathering("Dance party", "Gather with a bunch of people to have a dance off. Food included.", dateTwo, addressTwo, "sunny");

        Address addressThree = new Address("7 Oregon street", "Springfield", "Missouri");
        DateTime dateThree = new DateTime(16,8,24);
        Reception reception = new Reception("Marriage of Me", "Join while Greg and Abby get married, and then have a reception after.", dateThree, addressThree, "gregory@25thplace.com");

        lecture.createShort();
        Console.WriteLine();
        lecture.createStandard();
        Console.WriteLine();
        lecture.createFull();
        Console.WriteLine();
        
        gathering.createShort();
        Console.WriteLine();
        gathering.createStandard();
        Console.WriteLine();
        gathering.createFull();
        Console.WriteLine();

        reception.createShort();
        Console.WriteLine();
        reception.createStandard();
        Console.WriteLine();
        reception.createFull();
    
    
    
    }
}