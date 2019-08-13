namespace Vendor.Models
{
  public class Drink : Product
  {
    public int FluidOunces { get; set; }
    public Drink(int quantity, string name, decimal price, int oz) : base(price, name, quantity)
    {
      FluidOunces = oz;
    }
  }
}