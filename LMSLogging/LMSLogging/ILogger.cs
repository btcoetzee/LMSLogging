namespace Logging.Interface
{
    using System;

    public interface ILogger
    {
        void Log(ILoggerObject loggerObject);

        void Log(ILoggerErrorObject loggerErrorObject);
    }
}
