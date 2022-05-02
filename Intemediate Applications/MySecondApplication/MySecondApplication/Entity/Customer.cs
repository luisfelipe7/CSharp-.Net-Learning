using System;
using System.Collections.Generic;

namespace MySecondApplication.Entity
{
  public class Customer
  {
    // Attributes
    private int Id;
    private string Name;
    private List<Order> Orders;

    // Constructor
    public Customer()
    {
      this.Id = 0;
      this.Name = "";
      this.Orders = new List<Order>();

    }
    public Customer(int id, string name)
    : this()
    {
      this.Id = id;
      this.Name = name;
    }
    public Customer(int id)
    : this()
    {
      this.Id = id;
    }


    // Methods
    public void displayInformation()
    {
      Console.WriteLine("Hello, I am " + this.Name + " and my id is " + this.Id);
    }
    public void addOrder(Order orderToAdd)
    {
      this.Orders.Add(orderToAdd);
    }


  }
}
