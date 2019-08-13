using System;
using System.Collections.Generic;
using Vendor.Interfaces;

namespace Vendor.Models
{
  public class VendingMachine : IVendingMachine
  {
    public decimal TransactionBalance { get; set; }
    public decimal TotalBalance { get; set; }
    public List<Product> Products { get; set; }

    public void AddMoney(decimal amount)
    {
      //NOTE We define the logic within this class that's implementing the interface
      TransactionBalance += amount;
      Console.WriteLine($"your current balance is {TransactionBalance}");
    }

    public void ListAvailableProducts()
    {

    }

    public void AddProduct(Product productToAdd)
    {
      Products.Add(productToAdd);
    }

    public VendingMachine(decimal total)
    {
      TransactionBalance = 0;
      TotalBalance = total;
      Products = new List<Product>();
    }
  }
}