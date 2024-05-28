using Microsoft.AspNetCore.Mvc;

namespace C_Sharp_1_bili.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class WeatherForecastController : ControllerBase
	{
		private static readonly string[] Summaries = new[]
		{
		"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
	};

		private readonly ILogger<WeatherForecastController> _logger;

		public WeatherForecastController(ILogger<WeatherForecastController> logger)
		{
			_logger = logger;
		}

		[HttpGet(Name = "GetWeatherForecast")]
		public IEnumerable<WeatherForecast> Get()
		{
			return Enumerable.Range(1, 5).Select(index => new WeatherForecast
			{
				Date = DateTime.Now.AddDays(index),
				TemperatureC = Random.Shared.Next(-20, 55),
				Summary = Summaries[Random.Shared.Next(Summaries.Length)]
			})
			.ToArray();
		}
		[HttpGet("boc-bat-ho")]
		public double B1(int month, long money, double lai)
		{
			double a = lai / 100 / 12;
			double kq = money * Math.Pow(1 + a, month);
			return kq;
		}
		[HttpGet("pt-bac-hai")]
		public string ptBac2(double a, double b, double c)
		{
			if (a == 0)
			{
				string kq = "Hệ số a phải khác 0.";
				return kq;
			}

			double delta = b * b - 4 * a * c;
			if (delta > 0)
			{
				double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
				double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
				string kq = $"Phương trình có hai nghiệm phân biệt: x1 = {x1}, x2 = {x2}";
				return kq;
			}
			else if (delta == 0)
			{
				double x = -b / (2 * a);
				string kq = $"Phương trình có nghiệm kép: x = {x}";
				return kq;
			}
			else
			{
				string kq = "Phương trình vô nghiệm.";
				return kq;
			}
		}
		[HttpGet("chovy-ca-mau")]
		public string soNguyenTo(int a)
		{
			string kq = "";
			if(a < 2)
			{
				kq = $"{a} không phải là số nguyên tố";
			}
			for (int i= 2; i<=Math.Sqrt(a); i++)
			{
				if (a % i == 0)
				{
					kq = $"{a} không phải là số nguyên tố";
					return kq;
				}
			}
			kq = $"{a} là số nguyên tố";
			return kq;
		}
	}
}