public class Address{
    private string _streetAddress;
    private string _city;
    private string _state;


    public Address(string address, string city, string state){
        _streetAddress = address;
        _city = city;
        _state = state;
  
    }
    public string getAddress(){
        return $"{_streetAddress} {_city}, {_state}";
    }

}
