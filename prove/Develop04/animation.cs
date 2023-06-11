class Animation{
    private List<string> _animationList = new List<string>();

    public void createAnimation(int duration){
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(duration);
        
        int i=0;
        while (DateTime.Now < end){
            string part = _animationList[i];
            Console.Write(part);
            Thread.Sleep(500);
            Console.Write("\b");
            


            i+=1;
            if (i >= 4){
                i=0;
            }
        }
    }
    public void createAnimationList(){
        
        _animationList.Add("|");
        _animationList.Add("/");
        _animationList.Add("-");
        _animationList.Add("\\");
    }
    public void createCountdown(int duration){
        while (duration != 0){
            Console.Write(duration);
            Thread.Sleep(1000);
            Console.Write("\b");
            


            duration -=1;
    }
}
}