namespace Vendor.Models
{
  public class Food : Product
  {
    public bool IsFresh { get; set; }
    public bool IsCrushed { get; set; }

    public Food(int quantity, string name, int price) : base(price, name, quantity)
    {

    }
  }
}