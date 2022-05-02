using System;
using System.Threading.Tasks;

namespace MySecondApplication.Exercises.Four
{
  public class OracleConnection : DbConnection
  {
    public OracleConnection(string connectionString) : base(connectionString)
    {
    }

    public override void CloseConnection()
    {
      if (this.IsOpen == false)
      {
        Console.WriteLine("The connection is not open");
      }
      else
      {

        // Closing the connection
        var task = Task.Run(() =>
        {
          return "Closing the connection to the Oracle Database";
        });

        if (task.Wait(this.Timeout))
        {
          Console.WriteLine("Closed connection with Oracle Successfully");
          this.IsOpen = false;
        }
        else
        {
          throw new TimeoutException("Timed out, please check the connectivity with you Oracle Database");
        }

      }
    }

    public override void OpenConnection()
    {
      if (this.IsOpen == true)
      {
        Console.WriteLine("The connection is already opened");
      }
      else
      {
        if (String.IsNullOrEmpty(this.ConnectionString))
        {
          Console.WriteLine("The connection can't be open because the connection string is null or empty");
        }
        else
        {
          // Opening the connection
          var task = Task.Run(() =>
          {
            return "Connection to the Oracle Database";
          });

          if (task.Wait(this.Timeout))
          {
            Console.WriteLine("Opened connection with Oracle Successfully");
            this.IsOpen = true;
          }
          else
          {
            throw new TimeoutException("Timed out, please check the connectivity with you Oracle Database");
          }

        }


      }
    }

  }
}

