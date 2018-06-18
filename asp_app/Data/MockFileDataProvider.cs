using System;
using System.Globalization;
using System.Threading.Tasks;
using ComputingService.Data.Entities;
using ComputingService.Data.Interfaces;

namespace ComputingService.Data
{
	public class MockFileDataProvider : IDataProvider
	{
		public Task<Guid> SaveResult(string result)
		{
			return Task.FromResult(Guid.NewGuid());
		}

		public Task<Calculation> GetResult(Guid id)
		{
			return Task.FromResult(new Calculation
			{
				Result = new Random(DateTime.Today.Millisecond).NextDouble().ToString(CultureInfo.InvariantCulture),
				TimeStamp = DateTime.UtcNow
			});
		}
	}
}