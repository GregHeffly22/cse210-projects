
public class Product{
    private string _name;
    private int _productId;
    private double _price;
    private int _quantity;

    public Product(string name, int id, double price, int quantity){
        _name = name;
        _productId = id;
        _price = price;
        _quantity = quantity;
    }
    public double getTotal(){
        double total = _quantity * _price;
        return Math.Round(total, 2);
    
    }
    public string getName(){
        return _name;
    }
    public int getId(){
        return _productId;
    }
}