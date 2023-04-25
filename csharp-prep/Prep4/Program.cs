using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
       List<int> numbers = new List<int>();
       int addition = 1;
       float average = 0;
       int max = 0;
       int sum = 0;
       int count = 0;
       
       Console.WriteLine("Enter a list of numbers, type 0 when finished.");
       while (addition != 0)
       {
        Console.Write("Enter Number:");
        addition = Convert.ToInt32(Console.ReadLine());
        if (addition != 0)
        {
            numbers.Add(addition);
        }
       }
        foreach (int number in numbers)
        {
           
            if (number > max)
            {
                max = number;
            }
            sum = sum + number;
            count +=1;
        }
        average = sum / count;

        Console.WriteLine($"The Total is {sum}");
        Console.WriteLine($"The Average is {average}");
        Console.WriteLine($"The Maximum is {max}");
    }
}