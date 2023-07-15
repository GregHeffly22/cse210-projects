public class Order{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer){
        _customer = customer;
    }
    public void addProduct(Product product){
        _products.Add(product);
    }
    public string getShipping(){
        return $" {_customer.getName()} {_customer.getAddress()}" ;
    }
    public string getPacking(){
        string packing = "";
        foreach (Product product in _products){
            packing = packing + $"{product.getName()} {product.getId()}\n";
        }
        return packing;
    }
    public int getShippingCost(){
        if (_customer.isUSA()){
            return 5;
        }
        else return 35;
    }
    public double getTotal(){
        double total = 0;

        foreach (Product product in _products){
            total += product.getTotal();
        }
        return total + getShippingCost();
    }

}