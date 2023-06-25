public class Level{
    private List<Goal> _goals = new List<Goal>();
    private int _points;

    
    public Level(){
        _points = 0;
    }

    public void addPoints(int points){
        _points += points;
    }
    public void addGoal(Goal addition){
        _goals.Add(addition);
    }
    public void saveGoals(){
        Console.WriteLine("What file should I save it to?");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        outputFile.WriteLine($"_points\n");
        using (StreamWriter outputFile = new StreamWriter(fileName))
        foreach(Goal goal in _goals){
            outputFile.WriteLine($"{goal.getType()}:{goal.showInfo()}\n");
        }
        _goals.Clear();
        _points = 0;
       
    }
    public void loadGoals(){
        Console.WriteLine("What is the file name to load?");
        string fileName = Console.ReadLine();
        string text = File.ReadAllText(fileName);
        string[] lines = text.Split(Environment.NewLine);
        int count = 0;
 
        foreach (string line in lines) {
            if (line == "\n" ||  line == ""  || line == " "){
                continue;
            }
            if (count == 0){
                _points = Convert.ToInt16(line);
                continue;
            }
            string[] split = line.Split(":");
            string type = split[0];
            string[] info = split[1].Split(",");
            
            switch (type){
                case "simpleGoal": 
                    Simple newSgoal = new Simple();
                    newSgoal.setGoal(info);
                    _goals.Add(newSgoal);
                    Console.WriteLine(newSgoal.showInfo());
                break;
                case "eternalGoal":
                    Eternal newEgoal = new Eternal();
                    newEgoal.setGoal(info);
                    _goals.Add(newEgoal);
                break;
                case "checklistGoal":
                    Checklist newCgoal = new Checklist();
                    newCgoal.setGoal(info);
                    _goals.Add(newCgoal);
                break;
            }
            
        }

    }
    public void showGoals(){
        int count = 0;
        Console.WriteLine("Here are your goals:");
        foreach (Goal goal in _goals){
            count +=1;
            string type = goal.getType();
            string sign = " ";
            switch (type){
                case "simpleGoal":
                    if (goal.getStatus()){
                        sign = "x";
                    }
                    Console.WriteLine($"{count} [{sign}] {goal.showInfo()}");
                break;
                case "checklistGoal":
                    if (goal.getStatus()){
                        sign = "x";
                    }
                    Console.WriteLine($"{count} [{sign}] {goal.showPrintableInfo()}");
                break;
                default: Console.WriteLine($"{count} {goal.showPrintableInfo()}");
                break;
            }
        }
    }
    public List<Goal> getGoals(){
        return _goals;
    }
    public int getScore(){
        return _points;
    }

}