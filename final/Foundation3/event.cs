public class Event{
    protected string _title;
    protected string _description;
    protected DateTime _date;
    protected Address _address;
    protected string _type;

   
    public void createStandard(){
        Console.WriteLine(_title);
        Console.WriteLine(_description);
        Console.WriteLine($"This will take place at {_address.getAddress()} on {_date}");
    }
    public void createShort(){
        Console.WriteLine(_title);
        Console.WriteLine(_type);
        Console.WriteLine(_date);
        }
}