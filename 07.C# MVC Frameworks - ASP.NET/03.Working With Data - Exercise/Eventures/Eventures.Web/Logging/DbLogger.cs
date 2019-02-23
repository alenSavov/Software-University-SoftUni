using Eventures.Data;
using Eventures.Models;
using Microsoft.Extensions.Logging;
using System;

namespace Eventures.Web.Logging
{
    public class DbLogger : ILogger
    {
        private string categoryName;
        private Func<string, LogLevel, bool> filter;
        private EventuresDbContext dbContext;

        public DbLogger(string categoryName, Func<string, LogLevel, bool> filter, EventuresDbContext dbContext)
        {
            this.categoryName = categoryName;
            this.filter = filter;
            this.dbContext = new EventuresDbContext();
        }

        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        public void Log<TState>(LogLevel logLevel,
            EventId eventId,
            TState state,
            Exception exception,
            Func<TState, Exception,
                string> formatter)
        {
            if (logLevel == LogLevel.Error)
            {
                this.dbContext.Logs.Add(new CustomLog());
                this.dbContext.SaveChanges();
            }
        }
    }
}
