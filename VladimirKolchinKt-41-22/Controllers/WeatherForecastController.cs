using Microsoft.AspNetCore.Mvc;

namespace VladimirKolchinKt_41_22.Controllers
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
            _logger.LogError("Method was called");
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPost(Name = "AddNewSummary")]
        public string[] AddNewSummary([FromBody] string newSummary)
        {
            _logger.LogError("New method was called");

            // ����������� ������ Summaries � ������
            var list = Summaries.ToList();

            // ��������� ����� summary � ������

            // ��������� ������ "������� ������" � ����� ������
            list.Add("������� ������");

            // ���������� ����������� ������ ��� ������ �����
            return list.ToArray();
        }


    }
}
