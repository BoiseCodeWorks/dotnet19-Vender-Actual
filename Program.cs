﻿using System;
using Vendor.Models;

namespace Vendor
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      //   Console.WriteLine("Hello World!");
      App app = new App();
      app.Setup();
      // Product example = new Product(); //NOTE We can never have an instantiated Product because of the abstract
    }
  }
}
