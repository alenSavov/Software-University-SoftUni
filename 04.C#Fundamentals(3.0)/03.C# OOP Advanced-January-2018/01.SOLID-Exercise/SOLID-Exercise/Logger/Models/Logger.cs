using Logger.Models.Contracts;
using System.Collections.Generic;

namespace Logger.Models
{
    public class Logger : ILogger
    {
        IEnumerable<IAppender> appenders;

        public Logger(IEnumerable<IAppender> appender)
        {
            this.appenders = appender;
        }

        public IReadOnlyCollection<IAppender> Appenders => (IReadOnlyCollection<IAppender>)this.appenders; 

        public void Log(IError error)
        {
            foreach (IAppender appender in this.appenders)
            {
                if (appender.Level <= error.Level)
                {
                    appender.Append(error);
                }
            }
        }
    }
}
