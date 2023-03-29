using Microsoft.AspNetCore.Mvc;
using Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BitMEX_Consumption.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IServiceinstrument _iinstrument;
        public HomeController(IServiceinstrument iinstrument) {
        _iinstrument = iinstrument;
        }
        // GET: api/<HomeController>
        [HttpGet]
        public async Task<object> Get()
        {
          return await _iinstrument.GetData();
           
        }

    }
}
