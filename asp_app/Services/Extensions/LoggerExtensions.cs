using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace ComputingService.Services.Extensions
{
    public static class LoggerExtensions
    {
	    public static ILoggingBuilder AddCustomLoggers(this ILoggingBuilder builder)
	    {
		    //builder.Services.AddSingleton<ILoggerProvider, FileLoggerProvider>();
		    builder.AddProvider(new FileLoggerProvider("log.txt"));
		    builder.AddProvider(new MockDatabaseLoggerProvider());

			return builder;
	    }

	    //public static ILoggingBuilder AddDatabaseLogging(this ILoggingBuilder builder)
	    //{
		   // builder.Services.AddSingleton<ILoggerProvider, MockDatabaseLoggerProvider>();
		   // return builder;
	    //}
	}
}
