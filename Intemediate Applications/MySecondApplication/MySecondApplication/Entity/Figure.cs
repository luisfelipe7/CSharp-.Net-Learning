using System;
namespace MySecondApplication.Entity
{
  public class Figure
  {
    protected int PositionX;
    protected int PositionY;

    public Figure()
    {
      Console.WriteLine("Initiallizing the class Figure");
    }

    public Figure(int positionX, int positionY)
    {
      Console.WriteLine("Initiallizing the class Figure with positions");
      this.PositionX = positionX;
      this.PositionY = positionY;
    }

    public virtual void Draw()
    {
      Console.WriteLine("I am a simple figure, located in (" + this.PositionX + "," + this.PositionY + ")");
    }


  }
}

