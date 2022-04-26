using System;
namespace MyFirstApplication.Applications
{
  public class Reference
  {
    static void Main(string[] args)
    {
      var a = 10;
      var b = a;
      b++;
      // Let's check their values
      Console.WriteLine("Value of a " + a + " and b is " + b);

      // Now checking with references (classes)
      var array = new int[3] { 1, 2, 3 };
      var array2 = array;
      array[0] = 7;

      for (int i = 0; i < array.Length; i++) {
        Console.WriteLine("Array[" + i + "] is:" + array[i]);
      }
      for (int i = 0; i < array2.Length; i++) {
        Console.WriteLine("Array2[" + i + "] is:" + array2[i]);
      }
      // Both arrays were modified

      // Using Persons
      Person person = new Person();
      person.name = "Luis";
      person.age = 24;
      Person person2 = person;
      person.IncreaseAgeBy10();

      // Both are pointing to the same place in memory
      person.Introduce();
      person2.Introduce();


    }
  }
}
