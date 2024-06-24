using Microsoft.AspNetCore.Mvc;

namespace SKG_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SKGController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<SKGController> _logger;

        public SKGController(ILogger<SKGController> logger)
        {
            _logger = logger;
        }
        [HttpDelete(Name = "delete")]
        public IEnumerable<SKGElement> Delete()
        {
            return Enumerable.Range(1, 5).Select(index => new SKGElement
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
        [HttpPost(Name = "create")]
        public IEnumerable<SKGElement> Create()
        {
            return Enumerable.Range(1, 5).Select(index => new SKGElement
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
        [HttpPut(Name = "update")]
        public IEnumerable<SKGElement> Update()
        {
            return Enumerable.Range(1, 5).Select(index => new SKGElement
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
        [HttpGet(Name = "read")]
        public IEnumerable<SKGElement> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new SKGElement
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
