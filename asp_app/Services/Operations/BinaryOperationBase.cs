﻿using System;
using System.ComponentModel;

namespace ComputingService.Services.Operations
{
    public abstract class BinaryOperationBase<T> : IBinaryOperation<T>
    {
	    public abstract string Name { get; }

	    protected T Left;
	    protected T Right;

	    public void Parse(string left, string right)
	    {
		    try
		    {
			    Left = (T)TypeDescriptor.GetConverter(typeof(T)).ConvertFromString(left);
			}
		    catch
		    {
			    throw new ArgumentParseException(nameof(left));
		    }

		    try
		    {
				Right = (T)TypeDescriptor.GetConverter(typeof(T)).ConvertFromString(right);
			}
		    catch
		    {
			    throw new ArgumentParseException(nameof(right));
		    }
		}

	    public abstract T Compute();
    }
}
