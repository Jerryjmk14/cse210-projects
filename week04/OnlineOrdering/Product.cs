public class Product
{
    //attributes
    private string _productName; 
    private int _productID;
    private int _price;
    private int _quantity;
    private int _totalCost;

    //constructor
    public Product(string name, int ID, int price, int quantity)
    {
        _productName = name;
        _productID = ID;
        _price = price;
        _quantity = quantity;
    }

    //methods
    public int CalculateTotalCostOfProduct()
    {
        _totalCost = _price * _quantity;
        return _totalCost;
    }
}