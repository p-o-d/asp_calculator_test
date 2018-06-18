using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using ComputingService.Data.Interfaces;
using ComputingService.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ComputingService.Services
{
    public class MockResultsRepository<T> : IResultsRepository where T : IDataProvider, new()
    {
	    private T _dataProvider;

		public MockResultsRepository()
		{
			_dataProvider = new T();
		}

	    public async Task<string> Save(string result)
	    {
			var id = await _dataProvider.SaveResult(result);
		    return id.ToString();
	    }

	    public async Task<IActionResult> Get(string id)
	    {
			var data = await _dataProvider.GetResult(Guid.Parse(id));
			var response = new Dictionary<string, string> { { "result", data.Result }, { "timestamp", data.TimeStamp.ToString(CultureInfo.InvariantCulture) } };
			return new JsonResult(response);
	    }
    }
}
