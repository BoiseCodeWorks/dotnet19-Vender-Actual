using Vendor.Models;
using System;

namespace Vendor
{
  public class App
  {
    public VendingMachine myMachine { get; set; }
    Boolean active = true;
    public void Setup()
    {
      //NOTE instantiate our data for the application
      Food ntrBtr = new Food("A1", 8, "Nutter Butter", 1.75m);
      Food noodles = new Food("A2", 3, "Cup of Noodles", 1.00m);
      Food butterFinger = new Food("A3", 3, "Butter Finger", 2.00m);
      Drink sprite = new Drink("B1", 7, "Sprite", 1.50m, 20);
      Drink tea = new Drink("B2", 7, "Yerba Mate", 3.50m, 12);
      Drink oj = new Drink("B3", 7, "Orange Juice", 2.00m, 16);
      myMachine = new VendingMachine(25.00m);

      // NOTE add the products to the vending machine
      myMachine.AddProduct(ntrBtr); //NOTE might have to specify to add this Food as a Product
      myMachine.AddProduct(noodles);
      myMachine.AddProduct(butterFinger);
      myMachine.AddProduct(sprite);
      myMachine.AddProduct(tea);
      myMachine.AddProduct(oj);

      Run();
    }

    public void Run()
    {
      System.Console.WriteLine("Welcome to Vendor");
      //1. Menu Navigation
      // 1a. View all products
      // 1aa. Purchase product
      //1b. add money
      while (active)
      {
        Menu();
      }
    }

    public void Menu()
    {
      Console.WriteLine("Hello Human!\n\r1) View Products \n\r2) Purchase\n\r3) Add a Quarter\n\r4) Leave me forever");

      string userString = Console.ReadLine();
      switch (userString)
      {
        case "1":
          myMachine.ListAvailableProducts();
          break;
        case "2":
          // myMachine.PurchaseProduct();
          break;
        case "3":
          myMachine.AddMoney(0.25m);
          break;
        case "4":
          active = false;
          break;
        default:
          Console.WriteLine("Invalid Selection");
          break;

      }

    }
  }
}