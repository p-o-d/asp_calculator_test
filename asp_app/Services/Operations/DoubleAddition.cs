
namespace ComputingService.Services.Operations
{
    public class DoubleAddition : BinaryOperationBase<double>
    {
	    public override string Name => "add";
	    public override double Compute()
	    {
		    return Left + Right;
	    }
    }
}
