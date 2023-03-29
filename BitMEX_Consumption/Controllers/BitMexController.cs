using Microsoft.AspNetCore.Mvc;
using Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BitMEX_Consumption.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BitMexController : ControllerBase
    {
        private readonly IServiceCrud _serviceCrud;
        public BitMexController(IServiceCrud serviceCrud) 
        {
            _serviceCrud = serviceCrud;
        }
        // GET: api/<BitMexController>
        [HttpGet]
        public async Task<object> Get()
        {
            return await _serviceCrud.GetAll();
        }

        [HttpGet("/Date")]
        public async Task<object> GetDataOrde()
        {
            return await _serviceCrud.GetDataOrde();
        }

        [HttpGet("/Simbol{Simbol}")]
        public async Task<object> GetBySimbol(string Simbol)
        {
            return await _serviceCrud.GetbySimbol(Simbol);
        }

    }
}
