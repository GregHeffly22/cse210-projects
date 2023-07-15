public class Lecture:Event{
    private string _speakerName;
    private int _capacity;

    public Lecture(string title, string description, DateTime date, Address address, string speaker, int capacity){
        _title = title;
        _description =description;
        _date = date;
        _address = address;
        _speakerName = speaker;
        _capacity = capacity;
        _type = "lecture";
    }
    public void createFull(){
        Console.WriteLine(_title);
        Console.WriteLine(_description);
        Console.WriteLine($"This will take place at {_address.getAddress()} on {_date}");
        Console.WriteLine($"{_speakerName} will be giving the lecture.");
        Console.WriteLine($"Only {_capacity} people may attend.");
    }
}