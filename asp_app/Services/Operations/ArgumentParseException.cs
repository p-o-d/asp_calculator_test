using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputingService.Services.Operations
{
    public class ArgumentParseException : Exception
    {
	    public string ArgumentName { get; }
	    public override string Message => $"Argument \'{ArgumentName}\' parse error.";

	    public ArgumentParseException(string argumentName)
	    {
		    ArgumentName = argumentName;
	    }
    }
}
