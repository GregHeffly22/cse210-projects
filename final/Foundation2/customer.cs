public class Customer{
    private string _firstName;
    private string _lastName;
    private Address _address;

    public Customer(string first, string last, Address address){
        _firstName = first;
        _lastName = last;
        _address = address;
    }
    public bool isUSA(){
        return _address.isUnitedStates();
    }
    public string getAddress(){
        return _address.getAddress();
    }
    public string getName(){
        return $"{_firstName} {_lastName}";
    }
}