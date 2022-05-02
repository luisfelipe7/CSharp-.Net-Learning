using System;
namespace MySecondApplication.Entity
{
  public class Point
  {
    private int X;
    private int Y;


    public Point()
    {
    }
    public Point(int x, int y)
    {
      this.X = x;
      this.Y = y;
    }

    public void Move(int x, int y)
    {
      this.X = x;
      this.Y = y;
    }
    public void Move(Point newPoint)
    {
      if (newPoint == null) {
        throw new ArgumentException("newPoint", "New Point can't be null");
      }

      this.X = newPoint.X;
      this.Y = newPoint.Y;
    }
    public void displayInformation()
    {
      Console.WriteLine("My point is located at : x->" + this.X + " and y->" + this.Y);
    }





  }
}
