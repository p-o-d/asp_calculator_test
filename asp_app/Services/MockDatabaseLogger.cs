using System;
using Microsoft.Extensions.Logging;

namespace ComputingService.Services
{
	public class MockDatabaseLogger : ILogger
	{
		public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception,
			Func<TState, Exception, string> formatter)
		{
			if (formatter != null)
				Console.WriteLine(formatter(state, exception) + Environment.NewLine);
		}

		public bool IsEnabled(LogLevel logLevel)
		{
			return true;
		}

		public IDisposable BeginScope<TState>(TState state)
		{
			return null;
		}
	}
}