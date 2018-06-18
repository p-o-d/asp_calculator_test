using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ComputingService.Services.Interfaces
{
	public interface IResultsRepository
	{
		Task<string> Save(string result);
		Task<IActionResult> Get(string id);
	}
}