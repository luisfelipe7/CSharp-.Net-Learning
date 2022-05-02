using System;
namespace MySecondApplication.Entity
{
  public class Triangle : Figure
  {
    public Triangle()
    {
      Console.WriteLine("Initiallizing the class Triangle");
    }
    public Triangle(int positionX, int positionY) : base(positionX, positionY)
    {
      Console.WriteLine("Initiallizing the class Triangle with positions");
    }
    public override void Draw()
    {
      Console.WriteLine("I am a Triangle, located in (" + this.PositionX + "," + this.PositionY + ")");
    }


  }
}

