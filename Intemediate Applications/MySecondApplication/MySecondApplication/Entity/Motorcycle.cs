using System;
namespace MySecondApplication.Entity
{
  public class Motorcycle : Vehicle
  {
    public Motorcycle()
    {
      Console.WriteLine("Motorcycle is being initialized");
    }
    public Motorcycle(string registrationNumber) : base(registrationNumber)
    {
      Console.WriteLine("Motorcycle is being initialized " + registrationNumber);
    }

  }
}

