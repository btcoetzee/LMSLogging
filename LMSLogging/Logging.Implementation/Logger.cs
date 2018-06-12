namespace Logging.Implementation
{
    using Logging.Interface;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Logger : ILogger
    {
        public void Log(ILoggerObject loggerObject)
        {
            throw new NotImplementedException();
        }

        public void Log(ILoggerErrorObject loggerErrorObject)
        {
            throw new NotImplementedException();
        }
    }
}
