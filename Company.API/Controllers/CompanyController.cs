using Company.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Company.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CompanyController : ControllerBase
    {
        private readonly IDbService _db;
        public CompanyController(IDbService db) => _db = db;

        // GET: api/<CompanyController>
        [HttpGet]
        public async Task<IResult> Get() =>
            Results.Ok(await _db.HttpGetAsync<_Company, CompanyDTO>());

        // GET api/<CompanyController>/5
        [HttpGet("{id}")]
        public async Task<IResult> Get(int id) =>
            await _db.HttpSingleAsync<_Company, CompanyDTO>(id);
       
            
        // POST api/<CompanyController>
        [HttpPost]
        public async Task<IResult> Post([FromBody] CompanyDTO dto) =>
            await _db.HttpPostAsync<_Company, CompanyDTO>(dto);
       

        // PUT api/<CompanyController>/5
        [HttpPut("{id}")]
        public async Task<IResult> Put(int id, [FromBody] CompanyDTO dto) =>
            await _db.HttpPutAsync<_Company, CompanyDTO>(id, dto);


        // DELETE api/<CompanyController>/5
        [HttpDelete("{id}")]
        public async Task<IResult> Delete(int id) =>
            await _db.HttpDeleteAsync<_Company>(id);
 
    }
}
