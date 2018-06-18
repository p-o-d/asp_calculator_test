using Microsoft.Extensions.Logging;

namespace ComputingService.Services.Extensions
{
	public static class LoggerExtensions
	{
		public static ILoggingBuilder AddCustomLoggers(this ILoggingBuilder builder)
		{
			builder.AddProvider(new FileLoggerProvider("log.txt"));
			builder.AddProvider(new MockDatabaseLoggerProvider());

			return builder;
		}
	}
}