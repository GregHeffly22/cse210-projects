public abstract class Goal{
    protected string _name;
	protected int _score;
	protected string _description;
    protected string _type;
    protected bool _isComplete;

    public bool getStatus(){
        return _isComplete;
    }
    private Goal(string name, string description, int score){
        _name = name;
        _description = description;
        _score = score;
    }
    private Goal(string[] info){
        foreach (string i in info){
            _name = info[0];
            _description = info[1];
            _score = Convert.ToInt16(info[2]);
        }
    }
    protected Goal(){}
    
    public virtual string showInfo(){
        return $"{_name},{_description},{_score}";
    }
    public virtual string showPrintableInfo(){
        return $"{_name}: {_score} points";
    }
    public string getType(){
        return _type;
    }
 


    public virtual string[] getGoal(){
        Console.WriteLine("What is the name of the goal?");
        string name = Console.ReadLine();
        Console.WriteLine("Write a short descrtiption");
        string description = Console.ReadLine();
        Console.WriteLine("How many points is the goal worth?");
        string score = Console.ReadLine();
        string[] green = new string[]{name,description,score};
        return green;
    }
    public virtual void setGoal(string[] info){
        foreach (string i in info){
            _name = info[0];
            _description = info[1];
            _score = Convert.ToInt16(info[2]);
            _type = "goal";
        }
    }

    public virtual void recordEvent(Level level){
                level.addPoints(_score);
                _isComplete = true;
        }
    }
