using System;

namespace ComputingService.Services.Operations
{
	public class ArgumentParseException : Exception
	{
		public ArgumentParseException(string argumentName)
		{
			ArgumentName = argumentName;
		}

		public string ArgumentName { get; }
		public override string Message => $"Argument \'{ArgumentName}\' parse error.";
	}
}