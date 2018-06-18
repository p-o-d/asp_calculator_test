﻿using Microsoft.Extensions.Logging;

namespace ComputingService.Services
{
    public class FileLoggerProvider : ILoggerProvider
    {
	    private readonly string _path;

	    public FileLoggerProvider(string path)
	    {
		    _path = path;
	    }

	    public void Dispose()
	    {
	    }

	    public ILogger CreateLogger(string categoryName)
	    {
		    return new FileLogger(_path);
	    }
    }
}
