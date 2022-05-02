using System;
namespace MySecondApplication.Exercises.Two
{
  public class Post
  {
    private double Id;
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime CreatedDateTime { get; set; }
    public double Votes { get; set; }

    public Post()
    {
      this.Votes = 0;
      this.CreatedDateTime = DateTime.Now;
    }

    public double getId()
    {
      return this.Id;
    }
    public void setId(double id)
    {
      this.Id = id;
    }

    public void displayInformation()
    {
      Console.WriteLine("-------------------------------------------");
      Console.WriteLine("Id: " + this.Id);
      Console.WriteLine("Tittle: " + this.Title);
      Console.WriteLine("Description: " + this.Description);
      Console.WriteLine("Created: " + this.CreatedDateTime.ToLongTimeString());
      Console.WriteLine("Votes: " + this.Votes);
    }

  }
}
