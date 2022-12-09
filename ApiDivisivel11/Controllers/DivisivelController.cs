using Microsoft.AspNetCore.Mvc;

namespace ApiDivisivel11.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DivisivelController : ControllerBase
    {
        private readonly ILogger<DivisivelController> _logger;

        public DivisivelController(ILogger<DivisivelController> logger)
        {
            _logger = logger;   
        }


        private static readonly int[] Summaries = new[]
       {
        11,120,800,12
       };



        //[HttpGet(Name = "GetDivisivel")]
        //public IEnumerable<WeatherForecast> GetDivisivel()
        //{
        //    return Enumerable.Range(1, 5).Select(index => new Divisivel
        //    {
        //        divisivel = false,
        //        Numero = Summaries[Random.Shared.Next()],





        //    }).ToArray();    
            
            
            
        
    }
}
