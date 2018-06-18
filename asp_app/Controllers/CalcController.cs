using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ComputingService.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ComputingService.Controllers
{
    [Route("api/[controller]")]
    public class CalcController : Controller
    {
	    private readonly ICalculatorService _calculator;
	    private readonly IResultsRepository _resultsRepository;
	    private readonly ILogger<CalcController> _logger;


		public CalcController(ICalculatorService calculator,
			IResultsRepository resultsRepository,
			ILogger<CalcController> logger)
	    {
		    _calculator = calculator;
		    _resultsRepository = resultsRepository;
		    _logger = logger;
	    }

		// GET api/calc?left={DOUBLE_VAL}&right={DOUBLE_VAL}&operation={add|sub|mul|div|exp}
		[HttpGet]
        public async Task<IActionResult> GetAsync(string left, string right, string operation)
		{
			var responce = new Dictionary<string, string>();
			try
			{
				var result = _calculator.Calculate(left, right, operation);
				var id = await _resultsRepository.Save(result);
				_logger.LogInformation($"Result: {result}, Id: {id}");
				responce.Add("result", result);
				responce.Add("id", id);
				return new JsonResult(responce);
			}
			catch (Exception e)
			{
				_logger.LogError(e, $"Error: {e.Message}");
				responce.Add("error", e.Message);
				return new JsonResult(responce);
			}
		}
    }
}
