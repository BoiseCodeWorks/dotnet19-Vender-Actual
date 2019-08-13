using Vendor.Models;
using System;

namespace Vendor
{
  public class App
  {
    public VendingMachine myMachine { get; set; }
    public void Setup()
    {
      //NOTE instantiate our data for the application
      Food ntrBtr = new Food(8, "Nutter Butter", 1.75m);
      Food noodles = new Food(3, "Cup of Noodles", 1.00m);
      Food butterFinger = new Food(3, "Butter Finger", 2.00m);
      Drink sprite = new Drink(7, "Sprite", 1.50m, 20);
      Drink tea = new Drink(7, "Yerba Mate", 3.50m, 12);
      Drink oj = new Drink(7, "Orange Juice", 2.00m, 16);
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

    }

    public void Menu()
    {
      Console.WriteLine("Hello Human!\n\r1) View Products \n\r2) Purchase\n\r3) Leave me forever");
      bool isValid = false;
      string userString = "";
      while (!isValid)
      {
        userString = Console.ReadLine();
        switch (userString)
        {
          case "1":
            myMachine.ListAvailableProducts();
            break;
        }

      }

    }
  }
}