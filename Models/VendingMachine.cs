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
      Console.Clear();
      //NOTE We define the logic within this class that's implementing the interface
      TransactionBalance += amount;
      Console.WriteLine($"your current balance is {TransactionBalance}");
    }

    public void ListAvailableProducts()
    {
      Console.Clear();
      foreach (var item in Products)
      {
        if (item.Available)
        {
          Console.WriteLine($"Location: {item.Location} Item: {item.Name}  Price: {item.Price}");
        }
      }
      Console.WriteLine("Press Enter to continue.");
      Console.ReadLine();
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

    public void PurchaseProduct()
    {
      Console.WriteLine("Enter location:");
      string userChoice = Console.ReadLine();
      Product productToPurchase = Products.Find(p => p.Location == userChoice.ToUpper());
      if (productToPurchase == null)
      {
        System.Console.WriteLine("Invalid location");
      }
      else
      {
        //1. Enough money to buy?
        //2. is Availble
        //3. if 1 and 2 then subtract productPrice from TransactionBalance and decrement product quantity

        if (TransactionBalance < productToPurchase.Price)
        {
          System.Console.WriteLine("Insufficient funds");
          return;
        }

        if (!productToPurchase.Available)
        {
          System.Console.WriteLine(" Product not available");
          return;
        }

        TransactionBalance -= productToPurchase.Price;
        productToPurchase.Quantity--;

        TotalBalance += productToPurchase.Price;

      }


    }
  }
}