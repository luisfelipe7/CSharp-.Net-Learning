using System;
namespace MySecondApplication.Entity
{
  public class DbMigrator
  {

    private readonly Logger Logger;


    public DbMigrator(Logger logger)
    {
      this.Logger = logger;
    }

    public void Migrate()
    {
      this.Logger.Log("We are migrating the data.....");
    }

  }
}
