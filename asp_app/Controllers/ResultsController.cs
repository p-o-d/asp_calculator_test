using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ComputingService.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ComputingService.Controllers
{
	[Route("api/[controller]")]
	public class ResultsController : Controller
	{
		private readonly IResultsRepository _resultsRepository;
		private readonly ILogger<ResultsController> _logger;

		public ResultsController(IResultsRepository resultsRepository, ILogger<ResultsController> logger)
		{
			_resultsRepository = resultsRepository;
			_logger = logger;
		}

		// GET api/results/{RESULT_GUID}
		[HttpGet("{id}")]
		public async Task<IActionResult> GetAsync(string id)
		{
			try
			{
				var result = await _resultsRepository.Get(id);
				_logger.LogInformation($"Result with id: {id} found.");
				return result;
			}
			catch (Exception e)
			{
				_logger.LogError(e, $"Error: {e.Message}");
				var responce = new Dictionary<string, string> { { "error", e.Message } };
				return new JsonResult(responce);
			}
		}
	}
}