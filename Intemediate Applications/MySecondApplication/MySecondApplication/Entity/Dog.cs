using System;
namespace MySecondApplication.Entity
{
  public class Dog : Animal
  {
    public Dog()
    {
    }

    public override void MakeSound()
    {
      Console.WriteLine("Gua Guau!");
    }
  }
}

