using Microsoft.AspNetCore.Mvc;

using System.Dynamic;


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
        11,120,800,12,128,1331,14641
       };



        [HttpGet(Name = "GetDivisivel")]
        public IEnumerable<Divisivel> GetDivisivel()
        {
            return Enumerable.Range(0,7).Select(index => new Divisivel
            {
                Numero = Summaries[index],
                divisivel = Summaries[index] % 11 == 0 ? true : false


            }).ToArray();
            

        }


        }
}
