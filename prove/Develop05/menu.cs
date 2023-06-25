public abstract class Menu{
    protected List<string> _options;
    protected string _prompt;


    public virtual void displayMenu(Level stats){
        Console.WriteLine("Menu Options:");
        int number = 1;
        foreach (string i in _options){
            Console.WriteLine($"{number}. {i}");
            number +=1;
        }
        Console.WriteLine(_prompt);
    }
}