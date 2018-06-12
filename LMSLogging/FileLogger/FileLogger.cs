namespace File.Logger
{
    using Logging.Interface;
    using System;
    using System.IO;

    public class FileLogger : ILogger
    {

        string LogFilename = "C:\\null\\LMSLoggingForNow.txt";
        string ErrorLogFilename = "C:\\null\\LMSErrorLoggingForNow.txt";
        /// <summary>
        /// Log Output to the LogFile
        /// </summary>
        /// <param name="loggerObject"></param>
        public void Log(ILoggerObject loggerObject)
        {
            // Append if File Exists
            using (FileStream logFile = new FileStream(LogFilename, FileMode.Append, FileAccess.Write))
            using (StreamWriter streamWriter = new StreamWriter(logFile))
            {
                streamWriter.WriteLine(loggerObject.SolutionContext + "\t" + loggerObject.ProcessContext + "\t" + loggerObject.OperationContext);
                streamWriter.Close();
            }
        }

        public void Log(ILoggerErrorObject loggerErrorObject)
        {
            // Append if File Exists
            using (FileStream logFile = new FileStream(LogFilename, FileMode.Append, FileAccess.Write))
            using (StreamWriter streamWriter = new StreamWriter(logFile))
            {
                streamWriter.WriteLine(loggerErrorObject.SolutionContext + "\t" + loggerErrorObject.ProcessContext + "\t" + loggerErrorObject.OperationContext + "\t" + loggerErrorObject.ErrorContext + "\t" + loggerErrorObject.Exception);
                streamWriter.Close();
            }
        }
    }
}
