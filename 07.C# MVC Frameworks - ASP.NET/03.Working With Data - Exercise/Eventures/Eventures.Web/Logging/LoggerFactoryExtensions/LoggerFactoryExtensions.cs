using Eventures.Data;
using Microsoft.Extensions.Logging;
using System;

namespace Eventures.Web.Logging.LoggerFactoryExtensions
{
    public static class LoggerFactoryExtensions
    {

        public static ILoggerFactory AddContext(this ILoggerFactory factory, EventuresDbContext dbContext,
            Func<string, LogLevel, bool> filter)
        {
            factory.AddProvider(new DbLoggerProvider(filter, dbContext));
            return factory;
        }

        public static ILoggerFactory AddContext(this ILoggerFactory factory, LogLevel minLevel, EventuresDbContext dbContext)
        {
            return AddContext(
                factory,
                dbContext,
                (_, logLevel) => logLevel >= minLevel);
        }
    }
}
