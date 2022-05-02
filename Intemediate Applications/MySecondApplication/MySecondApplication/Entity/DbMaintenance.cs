using System;
namespace MySecondApplication.Entity
{
    public class DbMaintenance
    {
        private readonly ILogger _logger;

        // Doing dependency injection
        public DbMaintenance(ILogger logger)
        {
            this._logger = logger;
        }

        public void Migrate()
        {
            this._logger.LogInfo("Migration started at {0}" + DateTime.Now);

            // Details of maintaining the database

            this._logger.LogInfo("Migration finished at {0}" + DateTime.Now);
        }
    }
}

