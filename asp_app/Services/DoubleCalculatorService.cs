using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ComputingService.Services.Interfaces;
using ComputingService.Services.Operations;

namespace ComputingService.Services
{
	public class DoubleCalculatorService : ICalculatorService
	{
		private readonly List<IBinaryOperation<double>> _operations = new List<IBinaryOperation<double>>
		{
			new DoubleAddition(),
			new DoubleSubstraction(),
			new DoubleMultiplication(),
			new DoubleDivision(),
			new DoubleExponentiation()
		};

		public string Calculate(string left, string right, string opName)
		{
			IBinaryOperation<double> operation = null;

			try
			{
				operation = _operations.First(op => op.Name == opName);
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw new InvalidOperationException("Unsupported operation");
			}

			operation.Parse(left.Replace(',', '.'), right.Replace(',', '.'));
			return operation.Compute().ToString(CultureInfo.InvariantCulture);
		}
	}
}