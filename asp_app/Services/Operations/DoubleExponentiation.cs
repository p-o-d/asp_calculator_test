using System;

namespace ComputingService.Services.Operations
{
    public class DoubleExponentiation : BinaryOperationBase<double>
    {
	    public override string Name => "exp";
	    public override double Compute()
	    {
		    return Math.Pow(Left, Right);
	    }
    }
}
