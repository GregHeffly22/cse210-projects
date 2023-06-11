public class Listing:Activity{
    private List<string> _promptList = new List<string>();
 
    private void createStarters(){
        _promptList.Add("What are the last times you have felt the spirit?");
        _promptList.Add("Who are the most important people in your life?");
        _promptList.Add("How many times have you thought something good about someone today? What were the thoughts?");
        _promptList.Add("What are some of your favorite places to eat?");
        _promptList.Add("Have you seen anything cool today? What?");
    }
    public Listing(string name, string description){
        _name = name;
        _description = description;
    }
    public void startListing(){
        Console.Clear();
        Animation ani = new Animation();
        ani.createAnimationList();
        setOpening();
        displayIntro();
        ani.createAnimation(3);
        Console.WriteLine("How long would you like to list?");
        setDuration();
        
        Console.WriteLine("Get Ready...");
        
        
        ani.createAnimation(4);
        createStarters();

        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(getDuration());
        
        Random rnd = new Random();
        Console.WriteLine(_promptList[rnd.Next(0,5)]);


        int promptNumber = 0;
        while (DateTime.Now < end){
            Console.ReadLine();
            promptNumber +=1;
        }
        Console.WriteLine($"You listed {promptNumber} times for {getDuration()} seconds.");
        setClosing(getDuration());
        Console.WriteLine(getClosing());
        
        ani.createAnimation(5);


    }
}