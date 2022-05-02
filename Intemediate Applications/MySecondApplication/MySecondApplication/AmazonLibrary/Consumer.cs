using System;

namespace AmazonLibrary
{
  public class Consumer
  {
    public int Id { get; set; }
    public string Name { get; set; }

    public Consumer()
    {
    }

    public void Promote()
    {
      var calculator = new RateCalculator();
      var rating = calculator.Calculate(this);
      Console.WriteLine("Promote logic changed");
    }

    protected int CalculateRating(bool excludedOrders)
    {
      return 7;
    }

  }
}
