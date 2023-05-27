using System;


class Program
{
    static void Main(string[] args)
    {
        string response = "";
        // Set up the classes 
        // Scripture Nephi = new Scripture("17 And made the world as a wilderness, and destroyed the cities thereof, and opened not the house of his prisoners? \n18 All the kings of the nations, yea, all of them, lie in glory, every one of them in his own house."); 
        Scripture Nephi = new Scripture("I am Greg");
        Reference refer = new Reference("2Nephi","24","17","18");
        Random rnd = new Random();
        List<Word> wordList = Nephi.showScripture();
        Nephi.displayScripture();
        
        // This keeps track of hidden words
        int count = 0;
        int scriptureLength = wordList.Count();

        // The First Questions
        Console.WriteLine("\nType Quit to stop memorizing, press enter to continue.");
        response = Console.ReadLine();

         // Start USer interface Loop
        while (response != "quit"){
            List<Word> secondary = new List<Word>();
            foreach (Word word in wordList){
                    int criteria = rnd.Next(1,5);
                    if (criteria == 3) {
                        word.Hide();
                        secondary.Add(word);
                        count +=1;
                        if (count == scriptureLength){
                            System.Environment.Exit(0); 
                        }
                    }
                    else{
                        secondary.Add(word);
                    }
                    wordList=secondary;
                   
                    
                
            Nephi.setScripture(wordList);
            
            Console.Clear();

            }
        
            refer.displayReference();
            Nephi.displayScripture();
            
            

            Console.WriteLine("\nType Quit to stop memorizing, press enter to continue.");
            response= Console.ReadLine();
        

    }
}
}