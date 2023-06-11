using System;

class Program
{
    static void Main(string[] args)
    {
        string response = "0";
        while (response != "quit"){
            
            Breathing breathing = new Breathing("Breathing", "This activity will help calm your mind through regulated breathing.\nClear your mind, and get ready.","Breathe in....", "Now breathe out.");
            Reflect reflection = new Reflect("Reflecting", "This will help you look back on your life, and see the power there. This will build up your mental strength.");
            Listing listing = new Listing("Listing", "In this activity you will learn to appreciate things you migh tnot have by getting them down on paper.");
            
            Console.Clear();
            Console.WriteLine("Menu Options:\n  1. Start Breathing Activity\n  2. Start Reflecting Activity\n  3. Start Listing activity\n  4. Quit");
            response = Console.ReadLine();
            
            
            
            
            switch(response){
                case "1":
                    breathing.startBreathing();
                    break;
                case "2":
                    reflection.startReflecting();
                    break;
                case "3":
                    listing.startListing();
                    break;
                case "4":
                    Console.WriteLine("Thank you for meditating!");
                    System.Environment.Exit(0);
                    break;
                
            }


            
        }
    }
}