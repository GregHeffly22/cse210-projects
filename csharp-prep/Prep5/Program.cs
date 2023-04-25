using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome (string message)
            {
                Console.WriteLine($"{message}");
            }
        static string PromptUserName()
        {   Console.WriteLine("What is your name?");
            return Console.ReadLine();
        }
        static string PromptUserNumber()
        {   Console.WriteLine("What is your favorite number?");
            return Console.ReadLine();
        }
        static void DisplayResult(string message1, string message2)
        {
            Console.WriteLine($"{message1} your square is {message2}.");
        }
        static int CreateSquare(string number)
        {
            int part = 0;
            part = Convert.ToInt16(number);
            return part * part;

        }






            DisplayWelcome("Welcome!");
            string name = PromptUserName();
            string number = PromptUserNumber();
            DisplayResult(name,Convert.ToString(CreateSquare(number)));
            
    }
}