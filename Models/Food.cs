namespace Vendor.Models
{
  public class Food : Product
  {
    public bool IsFresh { get; set; }
    public bool IsCrushed { get; set; }

    public Food(string location, int quantity, string name, decimal price, bool fresh = true, bool crushed = false) : base(price, name, quantity, location)
    {
      IsFresh = fresh;
      IsCrushed = crushed;
    }
  }
}