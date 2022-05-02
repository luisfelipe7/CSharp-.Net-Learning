using System;
namespace MySecondApplication.Entity
{
  public class Person
  {
    // Attributes
    private string Name;

    // Constructor
    public Person()
    {
      Name = "";
    }
    public Person(string name)
    {
      this.Name = name;
    }

    // Setters and Getters


    // Methods
    public void Introduce()
    {
      Console.WriteLine("Hello, I am " + Name);
    }
    public static Person CreatePerson(string name)
    {
      return new Person(name);
    }

  }
}
