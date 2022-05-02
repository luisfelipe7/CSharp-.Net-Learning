using System;
using MySecondApplication.Entity;

namespace MySecondApplication.Applications
{
    public class Interface
    {
        static void Main(string[] args)
        {
            DbMaintenance dbMaintenance = new DbMaintenance(new ConsoleLogger());
            dbMaintenance.Migrate();

            dbMaintenance = new DbMaintenance(new FileLogger("/Library/"));
            dbMaintenance.Migrate();


        }
    }
}

