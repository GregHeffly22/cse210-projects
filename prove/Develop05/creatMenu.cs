public class Create : Menu{
    List<Goal> _goalNames = new List<Goal>();

    public override void displayMenu(Level stats){
        Console.WriteLine("Which kind of goal to complete?");
        int number = 1;
        foreach (string i in _options){
            Console.WriteLine($"{number}. {i}");
            number +=1;
        }
        Console.WriteLine(_prompt);
    }

    public Create(List<string> options, string prompt){
        _options = options;
        _prompt = prompt;
    }
}