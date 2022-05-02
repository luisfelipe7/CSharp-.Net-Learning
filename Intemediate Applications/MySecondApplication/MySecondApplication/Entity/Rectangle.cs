using System;
namespace MySecondApplication.Entity
{
  public class Rectangle : Figure
  {
    public Rectangle()
    {
      Console.WriteLine("Initiallizing the class Rectangle");
    }
    public Rectangle(int positionX, int positionY) : base(positionX, positionY)
    {
      Console.WriteLine("Initiallizing the class Rectangle with positions");
    }
    public override void Draw()
    {
      Console.WriteLine("I am a Rectangle, located in (" + this.PositionX + "," + this.PositionY + ")");
    }


  }
}

