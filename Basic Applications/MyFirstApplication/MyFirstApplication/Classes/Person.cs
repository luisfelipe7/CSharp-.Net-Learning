using System;
namespace MyFirstApplication
{
  public class Person
  {
    // Attributes
    public string name;
    public int age;


    // Constructor
    public Person()
    {
    }

    // Methods

    public void Introduce()
    {
      Console.WriteLine("My name is " + this.name + " and I am " + this.age + " years old");
    }

    public void IncreaseAgeBy10()
    {
      this.age += 10;
    }



  }
}
