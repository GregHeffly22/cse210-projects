using System;

class Program
{
    static void Main(string[] args)
    {

      int magicNumber = -1;
      int number = -2;  
      
      Console.WriteLine("What is your magic number");
      magicNumber = Convert.ToInt16(Console.ReadLine());
      
      
      while (number != magicNumber)
      {
        Console.WriteLine("What is your guess?");
        number = Convert.ToInt16(Console.ReadLine());
        if (number == magicNumber)
        {
            Console.WriteLine("You got it!");
        }
        else if (number > magicNumber)
        {
            Console.WriteLine("Lower");
        }
          else if (number < magicNumber)
        {
            Console.WriteLine("Higher");
        }
        else
        {
            Console.WriteLine("Please try again.");

        }
      }
    }
}