using System;
namespace MySecondApplication.Entity
{
  public class Car
  {
    private DateTime _launchDate;

    // Auto-implemented property
    public string Color { get; set; }
    // Auto-implemented with customization property
    public int Age {
      get {
        var timeSpan = DateTime.Today - this._launchDate;
        var years = timeSpan.Days / 365;

        return years;

      }
    }
    public string Brand { get; private set; }

    public Car(string brand)
    {
      this.Brand = brand;
    }

    public DateTime GetLaunchDate()
    {
      return _launchDate;
    }
    public void SetLaunchDate(DateTime _launchDate)
    {
      this._launchDate = _launchDate;
    }


    public void displayInformation()
    {
      Console.WriteLine("----- Car Information ------");
      Console.WriteLine("-- Launch Date " + this._launchDate.ToLongTimeString());
      Console.WriteLine("-- Color " + this.Color);
      Console.WriteLine("-- Age " + this.Age);
    }

  }
}
