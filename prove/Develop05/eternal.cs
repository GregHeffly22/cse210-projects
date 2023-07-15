public class Eternal:Goal{
   public Eternal(string name, string description, int points){
        _name = name;
        _description = description;
        _score = points;
    }
    public override string[] getGoal(){
        Console.WriteLine("What is the name of the goal?");
        string name = Console.ReadLine();
        Console.WriteLine("Write a short descrtiption");
        string description = Console.ReadLine();
        Console.WriteLine("How many points is each recording worth?");
        string score = Console.ReadLine();
        string[] green = new string[]{name,description,score};
        return green;
    }
    public override void setGoal(string[] info){
        foreach (string i in info){
            _name = info[0];
            _description = info[1];
            _score = Convert.ToInt16(info[2]);
            _type = "eternalGoal";
        }
    }
  
    
    
    public Eternal(){
    }

    
    public override string showPrintableInfo(){
        return $"{_name}: {_score} points every time";
    }
        public override void recordEvent(Level level){
                level.addPoints(_score);
        }
}