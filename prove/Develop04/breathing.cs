public class Breathing: Activity{
    private string _breathPromptIn;
    private string _breathPromptOut;


    public void startBreathing(){
        Animation ani = new Animation();
        // This is the bulk of the breathing activity.
        Console.Clear();
        setOpening();
        Console.WriteLine(getOpening());
        Console.WriteLine($"\n{getDescription()}");
        ani.createAnimationList();
        ani.createAnimation(3);
        // This is where I get the information for the duration
        Console.WriteLine("How long would you like to breath?");
        setDuration();
        // This part deals with how many repeats due to the chosen duration
        int repeat = getDuration() / 10;
        int remainder = getDuration() % 10;
        Animation countdown = new Animation();
        // This displays the breathing exercise itself
        while (repeat !=0){
           
            Console.WriteLine(_breathPromptIn);
            countdown.createCountdown(5);
            Console.WriteLine(_breathPromptOut);
            countdown.createCountdown(5);
            repeat -=1;
        }
        if (remainder/5 >=1){
            Console.WriteLine(_breathPromptIn);
            countdown.createCountdown(5);
            Console.WriteLine(_breathPromptOut);
            countdown.createCountdown(remainder-5);
        }
        else{
            Console.WriteLine(_breathPromptIn);
            countdown.createCountdown(remainder);
        }
        setClosing(getDuration());
        ani.createAnimation(3);
        Console.WriteLine(getClosing());
        ani.createAnimation(5);

    }
    public Breathing(string name, string description,string promptIn, string promptOut){
        _breathPromptIn = promptIn;
        _breathPromptOut = promptOut;
        _name = name;
        _description = description;
        
    }

    
}