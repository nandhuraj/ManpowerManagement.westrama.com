using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using Microsoft.Practices.EnterpriseLibrary.Logging.ExtraInformation;
using Microsoft.Practices.EnterpriseLibrary.Logging.Filters;

namespace ManpowerManage.Utilities
{
    public static class Logging
    {

        static ExceptionFormatter exceptionFormatter = new ExceptionFormatter();

        public static void LogExeption(Exception ex)
        {
            LogEntry logentry = new LogEntry();

            logentry.Message = FormatException(ex);

            logentry.TimeStamp = DateTime.Now;
            logentry.Severity = System.Diagnostics.TraceEventType.Error;
            Logger.Write(logentry);
        }

        public static void LogMessage(string message)
        {
            LogEntry logentry = new LogEntry();

            logentry.Message = message;
            logentry.TimeStamp = DateTime.Now;
            logentry.Severity = System.Diagnostics.TraceEventType.Information;

            Logger.Write(logentry);
        }

        private static string FormatException(Exception ex)
        {

            StringBuilder formatedException = new StringBuilder();

            formatedException.AppendFormat("Execpion Message : {0} {1} More Info : {2}", ex.Message, Environment.NewLine, ex.StackTrace);

            Exception inEx = ex.InnerException;
            int i = 0;
            while (inEx != null)
            {
                i++;

                formatedException.AppendFormat("{0}Inner Exception {1} Message : {2} {3} More Info : {4}",
                  Environment.NewLine, i, inEx.Message, Environment.NewLine, inEx.StackTrace);

                inEx = inEx.InnerException;
            }

            return formatedException.ToString();
        }
    }
}
