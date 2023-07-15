public class Gathering:Event{
    private string _weather;

    public Gathering( string title, string description, DateTime date, Address address, string weather){
        _title = title;
        _description =description;
        _date = date;
        _address = address;
        _weather = weather;
        _type = "gathering";
    }
    public void createFull(){
        Console.WriteLine(_title);
        Console.WriteLine(_description);
        Console.WriteLine($"This will take place at {_address.getAddress()} on {_date}");
        Console.WriteLine($"It will be {_weather} on that day, so dress appropriatly.");
    }
}