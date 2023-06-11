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
    protected Activity(){

    }
    protected void setOpening(){
        _openingMessage = $"Welcome to the {_name} activity.";
    }
    protected void setClosing(int duration){
        _closingMessage = $"You participated in {_name} for {duration} seconds";
    }
    protected void setDuration(){
        string duration = Console.ReadLine();
        _duration = Int16.Parse(duration);
        
    }
    protected string getClosing(){
        return _closingMessage;
    }
     protected string getOpening(){
        return _openingMessage;
    }
    protected string getDescription(){
        return _description;
    }
    protected int getDuration(){
        return _duration;
    }
    protected void displayIntro(){
        Console.Clear();
        Console.WriteLine(_openingMessage);
        Console.WriteLine($"\n{_description}");
    }
}   