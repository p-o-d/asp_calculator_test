using Microsoft.Extensions.Logging;

namespace ComputingService.Services
{
	public class MockDatabaseLoggerProvider : ILoggerProvider
	{
		public void Dispose()
		{
		}

		public ILogger CreateLogger(string categoryName)
		{
			return new MockDatabaseLogger();
		}
	}
}