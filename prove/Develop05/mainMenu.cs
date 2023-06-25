public class Main:Menu{
    List<Goal> _goalNames = new List<Goal>();

    public override void displayMenu(Level stats){
        Console.WriteLine($"You have {stats.getScore()} points");
        Console.WriteLine("Choose an Action:");
        int number = 1;
        foreach (string i in _options){
            Console.WriteLine($"{number}. {i}");
            number +=1;
        }
        Console.WriteLine(_prompt);
    }

    public Main( List<string> options, string prompt){
        _options = options;
        _prompt = prompt;
    }
}