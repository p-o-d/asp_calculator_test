
namespace ComputingService.Services.Operations
{
    public class DoubleSubstraction : BinaryOperationBase<double>
    {
	    public override string Name => "sub";
	    public override double Compute()
	    {
		    return Left - Right;
	    }
    }
}
