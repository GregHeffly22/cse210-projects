public class Checklist:Goal{
    private int _toComplete;
    private int _completed;
    private int _pointsEach;
    
    public string[] getGoal(){
        Console.WriteLine("What is the name of the goal?");
        string name = Console.ReadLine();
        Console.WriteLine("Write a short descrtiption");
        string description = Console.ReadLine();
        Console.WriteLine("How many points is it worth once all of it is completed?");
        string score = Console.ReadLine();
        Console.WriteLine("How many points per completion?");
        string pointsEach = Console.ReadLine();
        Console.WriteLine("How many times does this need to be completed?");
        string times = Console.ReadLine();
        
        
        string[] green = new string[]{name,description,score,times,pointsEach};
        return green;
    }
    public override void setGoal(string[] info){
        foreach (string i in info){
            _name = info[0];
            _description = info[1];
            _score = Convert.ToInt16(info[2]);
            _toComplete = Convert.ToInt16(info[3]);
            _pointsEach = Convert.ToInt16(info[4]);
            _type = "checklistGoal";
        }
    }
    public override string showInfo(){
       return $"{_name},{_description},{_score},{_toComplete},{_pointsEach}";
    }
    public override string showPrintableInfo(){
       return $"{_name} {_score} points, {_pointsEach} each time {_completed}/{_toComplete} completed";
    }
    public Checklist(){

    }
    public override void recordEvent(Level level){
        level.showGoals();
        List<Goal> goals = level.getGoals();
        Console.WriteLine("Which Goal would you like to record for?");
        string name = Console.ReadLine();
        foreach (Goal goal in goals){
            if (name == _name){
                if (_toComplete == _completed){
                    level.addPoints(_score);
                    _isComplete = true;
                }
                level.addPoints(_pointsEach);
                
            }
        }
    }
}