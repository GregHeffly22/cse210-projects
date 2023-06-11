class Reflect: Activity{
    private List<string> _starterPrompts = new List<string>();
    private List<string> _deepeningPrompts = new List<string>();
 
    private void createStarters(){
        _starterPrompts.Add("Think of the best Time of your life");
        _starterPrompts.Add("Think of the last time someone made you smile");
        _starterPrompts.Add("Think of a time someone taught you something new");
        _starterPrompts.Add("Think of a time someone touched your soul");
    }
    private void createDeepening(){
        _deepeningPrompts.Add("How did you feel?");
        _deepeningPrompts.Add("What happened before that?");
        _deepeningPrompts.Add("Who was there?");
        _deepeningPrompts.Add("Have you felt that way before?");
        _deepeningPrompts.Add("Have you thought about that before today?");
        _deepeningPrompts.Add("How can you remember that experience?");
        _deepeningPrompts.Add("What did you learn from that experience?");
    }
    public Reflect(string name, string description){
        _name = name;
        _description = description;
    }
    public void startReflecting(){
        Random rnd = new Random();
        Animation ani = new Animation();
        ani.createAnimationList();
        
        Console.Clear();
        setOpening();
        displayIntro();
        ani.createAnimation(3);
        Console.WriteLine("How long would you like to reflect?");
        setDuration();
        // Start
        Console.Clear();
        Console.WriteLine("Get Ready...");
        // Beginning animation
        
        ani.createAnimation(4);
        // Create Lists
        createStarters();
        createDeepening();
        // Set up variables for later
        int selector = rnd.Next(0,3);
        int repeat = getDuration() / 6;
        int remainder = getDuration() % 6;
        Console.WriteLine($"\n{_starterPrompts[selector]}");
        Console.WriteLine("Press Enter to Continue");
        Console.ReadLine();

        if (getDuration() <= 6){
            selector = rnd.Next(0,6);
            Console.WriteLine($"\n{_deepeningPrompts[selector]}");
            ani.createAnimation(remainder);
        }
        else{
            while (repeat > 0){
                selector = rnd.Next(0,6);
                Console.WriteLine($"\n{_deepeningPrompts[selector]}");
                ani.createAnimation(6);
                repeat-=1;
            }
            selector = rnd.Next(0,6);
            Console.WriteLine($"\n{_deepeningPrompts[selector]}");
            ani.createAnimation(remainder);
            
            Console.WriteLine(getClosing());
            ani.createAnimation(5);

        }



        

        

    }
}