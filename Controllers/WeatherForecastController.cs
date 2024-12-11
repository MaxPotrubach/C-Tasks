using Microsoft.AspNetCore.Mvc;

namespace PZ3.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class WeatherForecastController : ControllerBase
	{
		private static readonly string[] Summaries = new[]
		{
			"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
		};

		// Оголошуємо список _forecast на рівні класу
		private static List<WeatherForecast> _forecast = new List<WeatherForecast>();

		private readonly ILogger<WeatherForecastController> _logger;

		public WeatherForecastController(ILogger<WeatherForecastController> logger)
		{
			_logger = logger;
			// Заповнюємо список _forecast, якщо він порожній
			if (!_forecast.Any())
			{
				_forecast.AddRange(Enumerable.Range(1, 5).Select(index => new WeatherForecast
				{
					Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
					TemperatureC = Random.Shared.Next(-20, 55),
					Summary = Summaries[Random.Shared.Next(Summaries.Length)]
				}));
			}
		}

		// GET: /WeatherForecast
		[HttpGet(Name = "GetWeatherForecast")]
		public IEnumerable<WeatherForecast> Get()
		{
			return Enumerable.Range(1, 5).Select(index => new WeatherForecast
			{
				Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
				TemperatureC = Random.Shared.Next(-20, 55),
				Summary = Summaries[Random.Shared.Next(Summaries.Length)]
			})
			.ToArray();
		}

		// POST: /WeatherForecast
		[HttpPost]
		public IEnumerable<WeatherForecast> Post()
		{
			// Додаємо новий прогноз в список _forecast
			var newForecast = new WeatherForecast
			{
				Date = DateOnly.FromDateTime(DateTime.Now.AddDays(6)),
				TemperatureC = Random.Shared.Next(-20, 55),
				Summary = Summaries[Random.Shared.Next(Summaries.Length)]
			};

			_forecast.Add(newForecast);

			return _forecast;
		}

		// PUT: /WeatherForecast/{id}
		[HttpPut("{id}")]
		public IEnumerable<WeatherForecast> Put(int id)
		{
			var existingForecast = _forecast.FirstOrDefault(f => f.Date.DayNumber == id);
			if (existingForecast != null)
			{
				existingForecast.TemperatureC = Random.Shared.Next(-20, 55);
				existingForecast.Summary = Summaries[Random.Shared.Next(Summaries.Length)];
			}

			return _forecast;
		}

		// DELETE: /WeatherForecast/{id}
		[HttpDelete("{id}")]
		public IEnumerable<WeatherForecast> Delete(int id)
		{
			var forecastToDelete = _forecast.FirstOrDefault(f => f.Date.DayNumber == id);
			if (forecastToDelete != null)
			{
				_forecast.Remove(forecastToDelete);
			}

			return _forecast;
		}
	}
}
