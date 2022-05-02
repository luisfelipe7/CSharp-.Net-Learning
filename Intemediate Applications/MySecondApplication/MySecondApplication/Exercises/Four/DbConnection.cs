using System;
namespace MySecondApplication.Exercises.Four
{
  public abstract class DbConnection
  {
    protected string ConnectionString;
    protected TimeSpan Timeout;
    protected bool IsOpen;

    public DbConnection(string connectionString)
    {
      Console.WriteLine("\n Starting the constructor of the DB Connection");
      if (!String.IsNullOrEmpty(connectionString))
      {
        this.IsOpen = false;
        //10 Seconds Timeout
        this.Timeout = new TimeSpan(0, 0, 5);
        this.ConnectionString = connectionString;
        Console.WriteLine("Created DB Connection, timeout set for 10 seconds");
      }
      else
      {
        throw new ArgumentNullException("The connection string provided is null or empty");
      }
    }

    public abstract void OpenConnection();
    public abstract void CloseConnection();
  }
}

