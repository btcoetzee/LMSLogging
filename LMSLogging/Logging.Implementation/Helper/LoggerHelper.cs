using File.Logger;
using Logging.Implementation.Constants;
using Logging.Interface;
using System;

namespace Logging.Implementation
{
    public class LoggerHelper
    {
        private static ILogger logger;

        public static void Log(LoggerCofiguration.LogProvider provider,ILoggerObject loggerObject)
        {
            switch (provider)
            {
                case LoggerCofiguration.LogProvider.File:
                    logger = new FileLogger();
                    logger.Log(loggerObject);
                    break;
            }

            //var logger = IoC.Unity.Resolve<ILogger>("provider");
            // logger.Log(...);
        }

        public static void LogError(LoggerCofiguration.LogProvider provider, ILoggerErrorObject loggerErrorObject)
        {
            switch (provider)
            {
                case LoggerCofiguration.LogProvider.File:
                    logger = new FileLogger();
                    logger.Log(loggerErrorObject);
                    break;
            }
        }
    }
}
