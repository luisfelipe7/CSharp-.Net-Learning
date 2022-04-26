using System;
using System.Collections.Generic;

namespace MyFirstApplication.Applications
{
  public class DataStructure
  {
    static void Main(string[] args)
    {
      // -- Simple Array

      int[] numbers = new int[] { 3, 8, 9, 2, 14, 6 };
      Console.WriteLine("The size of the array is: " + numbers.Length);
      // Size
      var indexOf9 = Array.IndexOf(numbers, 9);
      // Index
      Console.WriteLine("The index of 9 is: " + indexOf9);
      // Clear
      Array.Clear(numbers, 0, 2);
      Console.WriteLine("Effect of Clear()");
      foreach (var number in numbers) {
        Console.WriteLine("Number : " + number);
      }
      // Copy
      int[] another = new int[3];
      Array.Copy(numbers, another, 3);
      Console.WriteLine("Effect of Copy()");
      foreach (var number in another) {
        Console.WriteLine("Copy Number : " + number);
      }
      // Sort
      Array.Sort(numbers);
      Console.WriteLine("Effect of Sort");
      foreach (var number in numbers) {
        Console.WriteLine("Number : " + number);
      }
      // Reverse
      Array.Reverse(numbers);
      Console.WriteLine("Effect of Reverse");
      foreach (var number in numbers) {
        Console.WriteLine("Number : " + number);
      }


      // -- Lists

      var numbers2 = new List<int>();
      numbers2.Add(5);
      numbers2.Add(6);
      // Add three elements at the same time or insert an array
      numbers2.AddRange(new int[3] { 5, 6, 7 });
      foreach (var number in numbers2) {
        Console.WriteLine("List-number: " + number);
      }
      // Index of 6
      Console.WriteLine("Index of 6: " + numbers2.LastIndexOf(6));
      // Count
      Console.WriteLine("Count: " + numbers2.Count);
      // Remove
      numbers2.Remove(5);
      Console.WriteLine("List after applying Remove()");
      foreach (var number in numbers2) {
        Console.WriteLine("List-number: " + number);
      }
      // We can't use foreach to modify the list, just normal for


    }
  }
}
