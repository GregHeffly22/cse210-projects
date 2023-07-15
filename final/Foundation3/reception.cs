public class Reception:Event{
    private string _email;

    
    public Reception( string title, string description, DateTime date, Address address, string email){
        _title = title;
        _description =description;
        _date = date;
        _address = address;
        _email = email;
        _type = "reception";
    }
    public void createFull(){
            Console.WriteLine(_title);
            Console.WriteLine(_description);
            Console.WriteLine($"This will take place at {_address.getAddress()} on {_date}");
            Console.WriteLine($"Please email {_email} to RSVP.");
    }
}