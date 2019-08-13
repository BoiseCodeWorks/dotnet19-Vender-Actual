using System.Collections.Generic;
using Vendor.Interfaces;

namespace Vendor.Models
{
  public class Crumb : Food, IVendingMachine, IExample//NOTE cannot inherent from multiple classes directly but may implement as many interfaces as you like
  {

    public Crumb(string location, int quantity, string name, decimal price, bool fresh = true, bool crushed = false) : base(location, quantity, name, price, fresh, crushed)
    {
    }

    public decimal TransactionBalance { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    public decimal TotalBalance { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    public List<Product> Products { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    public void AddMoney(decimal amount)
    {
      throw new System.NotImplementedException();
    }

    public void AddProduct(Product productToAdd)
    {
      throw new System.NotImplementedException();
    }

    public void ListAvailableProducts()
    {
      throw new System.NotImplementedException();
    }
  }
}