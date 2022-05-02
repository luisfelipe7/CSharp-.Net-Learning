using System;
namespace MySecondApplication.Entity
{
    public interface ILogger
    {
        void LogError(string message);
        void LogInfo(string message);
    }
}

