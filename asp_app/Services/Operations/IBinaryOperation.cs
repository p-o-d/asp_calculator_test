namespace ComputingService.Services.Operations
{
	public interface IBinaryOperation<T>
	{
		string Name { get; }
		void Parse(string left, string right);
		T Compute();
	}
}