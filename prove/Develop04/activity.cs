public class Activity{
    protected string _name;
    protected string _closingMessage;
    protected string _openingMessage;
    protected int _duration;
    protected string _description;
    protected string _countdownMessage;

    public Activity(string name, int duration){
        _name = name;
        _duration = duration;

    }
    public Activity(){

    }
    public Activity(string name, string description){
        _name = name;
        _description = description;
        _openingMessage = $"Welcome to the {_name} activity.";
    }
    public void setClosing(int duration){
        _closingMessage = $"You participated in {_name} for {duration} seconds";
    }
    public void setDuration(){
        string duration = Console.ReadLine();
        _duration = Int16.Parse(duration);
        
    }
    public string getClosing(){
        return _closingMessage;
    }
     public string getOpening(){
        return _openingMessage;
    }
    public string getDescription(){
        return _description;
    }
    public int getDuration(){
        return _duration;
    }
    public void displayIntro(){
        Console.Clear();
        Console.WriteLine(_openingMessage);
        Console.WriteLine($"\n{_description}");
    }
}   