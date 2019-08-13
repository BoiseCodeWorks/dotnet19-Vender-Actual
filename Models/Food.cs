namespace Vendor.Models
{
  public class Food : Product
  {
    public bool IsFresh { get; set; }
    public bool IsCrushed { get; set; }

    public Food(int quantity, string name, decimal price, bool fresh = true, bool crushed = false) : base(price, name, quantity)
    {
      IsFresh = fresh;
      IsCrushed = crushed;
    }
  }
}