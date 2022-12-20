using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Company.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TitleController : ControllerBase
    {
        private readonly IDbService _db;
        public TitleController(IDbService db) => _db = db;
        // GET: api/<TitleController>
        [HttpGet]
        public async Task<IResult> Get() =>
            await _db.HttpGetAsync<Title, TitleDTO>();


        // GET api/<TitleController>/5
        [HttpGet("{id}")]
        public async Task<IResult> Get(int id) =>
            await _db.HttpSingleAsync<Title, TitleDTO>(id);


        // POST api/<TitleController>
        [HttpPost]
        public async Task<IResult> Post([FromBody] TitleDTO dto) =>
            await _db.HttpPostAsync<Title, TitleDTO>(dto);


        // PUT api/<TitleController>/5
        [HttpPut("{id}")]
        public async Task<IResult> Put(int id, [FromBody] TitleDTO dto) =>
            await _db.HttpPutAsync<Title, TitleDTO>(id, dto);



        // DELETE api/<TitleController>/5
        [HttpDelete("{id}")]
        public async Task<IResult> Delete(int id) =>
            await _db.HttpDeleteAsync<Title>(id);
 
    }
}
