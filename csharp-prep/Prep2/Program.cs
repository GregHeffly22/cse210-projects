using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("What is your percentage in the class?");
        string percentageString = Console.ReadLine();
        char letter = 'F';
        char sign =' ';
        double percentage = Convert.ToDouble(percentageString);
        
        
        if (percentage >= 90)
        {
            letter = 'A';
        }
        else if (percentage >= 80)
        {
            letter = 'B';
        }
        else if (percentage >= 70)
        {
            letter = 'C';
        }
        else if (percentage >= 60)
        {
            letter = 'D';
        }
        else 
        {
            letter = 'F';
        }
        
        
        if (percentage >=  70)
        {
            Console.Write("You have passed! Congratulations!");
        }
        else
        {
            Console.Write("You have Failed. Please Try again!");
        }

        if (percentage >= 93)
        {
            sign = ' ';
        }
        else if (percentage < 60)
        {
            sign = ' ';
        }
        else if (percentage%10 < 3)
        {
            sign ='-';
        }
        else if (percentage%10 >= 6)
        {
            sign ='+';
        }



        Console.WriteLine($" You received a {letter}{sign}.");
    }
    
    }