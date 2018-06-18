using System;
using System.IO;
using Microsoft.Extensions.Logging;

namespace ComputingService.Services
{
	public class FileLogger : ILogger
	{
		private readonly object _lock = new object();
		private readonly string _path;

		public FileLogger(string path)
		{
			_path = path;
		}

		public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception,
			Func<TState, Exception, string> formatter)
		{
			if (formatter != null)
				lock (_lock)
				{
					File.AppendAllText(_path, formatter(state, exception) + Environment.NewLine);
				}
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