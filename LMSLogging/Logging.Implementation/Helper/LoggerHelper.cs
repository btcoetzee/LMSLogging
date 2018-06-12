using File.Logger;
using Logging.Implementation.Constants;
using Logging.Interface;
using System;

namespace Logging.Implementation
{
    public class LoggerHelper
    {
        private static ILogger logger;

        public static void Log(LoggerCofiguration.LogRecipient recipient,ILoggerObject loggerObject)
        {
            switch (recipient)
            {
                case LoggerCofiguration.LogRecipient.File:
                    logger = new FileLogger();
                    logger.Log(loggerObject);
                    break;
            }
        }

        public static void LogError(LoggerCofiguration.LogRecipient recipient, ILoggerErrorObject loggerErrorObject)
        {
            switch (recipient)
            {
                case LoggerCofiguration.LogRecipient.File:
                    logger = new FileLogger();
                    logger.Log(loggerErrorObject);
                    break;
            }
        }
    }
}
