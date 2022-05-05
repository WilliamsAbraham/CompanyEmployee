using Contracts;

using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerService

    
{
    public class LoggerManager : IloggerManager

    {
        private static ILogger logger = LogManager.GetCurrentClassLogger();
        public void LogDebug(string message)
        {
            logger.Debug(message);
            throw new NotImplementedException();
        }

        public void LogError(string message)
        {
            logger.Error(message);
            throw new NotImplementedException();
        }

        public void LogInfo(string message)
        {
            logger.Info(message);   
            throw new NotImplementedException();
        }

        public void LogWarn(string message)
        {
            logger.Warn(message);
            throw new NotImplementedException();
        }
    }
}
