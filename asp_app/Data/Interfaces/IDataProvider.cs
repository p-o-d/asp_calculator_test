using System;
using System.Threading.Tasks;
using ComputingService.Data.Entities;

namespace ComputingService.Data.Interfaces
{
	public interface IDataProvider
	{
		Task<Guid> SaveResult(string result);
		Task<Calculation> GetResult(Guid id);
	}
}