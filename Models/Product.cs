namespace Vendor.Models
{
  public abstract class Product
  {
    public int Price { get; set; }
    public int Quantity { get; set; }
    public string Name { get; set; }



    //NOTE parameter order at definition is arbitrary but at invokation must match what was defined
    public Product(int price, string name, int quantity)
    {
      Price = price;
      Name = name;
      Quantity = quantity;
    }
  }
}