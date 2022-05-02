using System;
using System.Collections.Generic;

namespace MySecondApplication.Entity
{
  public class Employee
  {
    private int Id;
    private string Name;
    // Initializing the field directly without the constructor
    public readonly List<Order> Orders = new List<Order>();

    public Employee()
    {
      Orders = new List<Order>();
    }

    public Employee(int id)
    {
      this.Id = id;
    }
    public Employee(int id, string name) : this(id)
    {
      this.Name = name;
    }


    public void addOrder(Order orderToAdd)
    {
      this.Orders.Add(orderToAdd);
    }
    public void displayInformation()
    {
      Console.WriteLine("--- Employee Information ---");
      Console.WriteLine("- Id: " + this.Id);
      Console.WriteLine("- Name: " + this.Name);
    }


  }
}
