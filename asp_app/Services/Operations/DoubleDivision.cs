
namespace ComputingService.Services.Operations
{
    public class DoubleDivision : BinaryOperationBase<double>
    {
	    public override string Name => "div";
	    public override double Compute()
	    {
		    return Left / Right;
	    }
    }
}
