using System;

class Program
{
    static void Main(string[] args)
    {
        string response = "0";
        while (response != "quit"){
            
            Activity breathing = new Activity("Breathing", "This activity will help calm your mind through regulated breathing.\nClear your mind, and get ready.");
            Activity reflection = new Activity("Reflecting", "This will help you look back on your life, and see the power there. This will build up your mental strength.");
            Activity listing = new Activity("Listing", "In this activity you will learn to appreciate things you migh tnot have by getting them down on paper.");
            
            Console.Clear();
            Console.WriteLine("Menu Options:\n  1. Start Breathing Activity\n  2. Start Reflecting Activity\n  3. Start Listing activity\n  4. Quit");
            response = Console.ReadLine();
            
            
            
            
            switch(response){
                case "1":
                    Breathing starterBreath = new Breathing("Breathe in....", "Now breathe out."); 
                    starterBreath.startBreathing(breathing);
                    break;
                case "2":
                    Reflect starterReflect = new Reflect();
                    starterReflect.startReflecting(reflection);
                    break;
                case "3":
                    Listing starterListing = new Listing();
                    starterListing.startListing(listing);
                    break;
                case "4":
                    Console.WriteLine("Thank you for meditating!");
                    System.Environment.Exit(0);
                    break;
                
            }


            
        }
    }
}