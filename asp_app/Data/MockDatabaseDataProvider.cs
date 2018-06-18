using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ComputingService.Data.Entities;
using ComputingService.Data.Interfaces;

namespace ComputingService.Data
{
	public class MockDatabaseDataProvider : IDataProvider
	{
		private readonly Dictionary<Guid, Calculation> _mockDB = new Dictionary<Guid, Calculation>();

		Task<Guid> IDataProvider.SaveResult(string result)
		{
			var newId = Guid.NewGuid();
			lock (_mockDB)
			{
				while (_mockDB.ContainsKey(newId))
					newId = Guid.NewGuid();
				_mockDB.Add(newId, new Calculation {Result = result, TimeStamp = DateTime.UtcNow});
			}

			return Task.FromResult(newId);
		}

		Task<Calculation> IDataProvider.GetResult(Guid id)
		{
			lock (_mockDB)
			{
				return Task.FromResult(_mockDB[id]);
			}
		}
	}
}