public class Address{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;


    public Address(string address, string city, string state, string country){
        _streetAddress = address;
        _city = city;
        _state = state;
        _country = country;
    }
    public string getAddress(){
        return $"{_streetAddress} {_city}, {_state} {_country}";
    }
    public bool isUnitedStates(){
        if (_country == "USA"){
            return true;
        }
        else return false;
    }

}
