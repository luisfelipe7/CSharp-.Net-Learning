using System;
namespace MySecondApplication.Entity
{
  public abstract class Animal
  {
    public abstract void MakeSound();
    public void Eat()
    {
      Console.WriteLine("I am eating some food");
    }
  }
}

