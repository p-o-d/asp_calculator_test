namespace ComputingService.Services.Operations
{
	public class DoubleMultiplication : BinaryOperationBase<double>
	{
		public override string Name => "mul";

		public override double Compute()
		{
			return Left * Right;
		}
	}
}