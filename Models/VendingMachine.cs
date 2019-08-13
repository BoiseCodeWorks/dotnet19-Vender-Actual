using Vendor.Interfaces;

namespace Vendor.Models
{
  public class VendingMachine : IVendingMachine
  {
    public int TransactionBalance { get; set; }
    public int TotalBalance { get; set; }
    public System.Collections.Generic.List<Product> Products { get; set; }

    public void AddMoney(int amount)
    {
      //NOTE We define the logic within this class that's implementing the interface
    }

    public void ListAvailableProducts()
    {

    }
  }
}