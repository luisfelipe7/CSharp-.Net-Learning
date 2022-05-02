using System;
namespace MySecondApplication.Entity
{
  public class Cat : Animal
  {
    public Cat()
    {
    }

    public override void MakeSound()
    {
      Console.WriteLine("Miau Miau!");
    }
  }
}

