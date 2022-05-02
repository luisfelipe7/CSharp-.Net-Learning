using System;
namespace MySecondApplication.Entity
{
  public class Calculator
  {

    public Calculator()
    {
    }

    public int Sum(params int[] numbers)
    {
      var sum = 0;
      foreach (var number in numbers) {
        sum += number;
      }
      return sum;
    }


  }
}
