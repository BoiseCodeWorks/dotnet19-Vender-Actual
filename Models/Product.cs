namespace Vendor.Models
{
  public abstract class Product
  {
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public string Name { get; set; }
    public bool Available { get { return Quantity > 0; } set { return; } }

    //NOTE parameter order at definition is arbitrary but at invokation must match what was defined
    public Product(decimal price, string name, int quantity)
    {
      Price = price;
      Name = name;
      Quantity = quantity;
    }
  }
}