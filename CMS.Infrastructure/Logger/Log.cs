using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Infrastructure.Logger
{
    public class Log
    {
        private static ILogger logger = LogManager.GetCurrentClassLogger();

        public static void Error(Exception ex, string msg)
        {
            logger.Error(ex, msg);
        }

        public static void Info(string msg)
        {
            logger.Info(msg);
        }

        public static void Debug(string msg, Exception ex = null)
        {
            logger.Info(ex, msg);
        }

        public static void Warn(Exception ex, string msg)
        {
            logger.Warn(ex, msg);
        }
    }
}
