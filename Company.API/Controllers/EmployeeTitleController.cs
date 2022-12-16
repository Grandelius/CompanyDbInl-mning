using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Company.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeTitleController : ControllerBase
    {
        private readonly IDbService _db;
        public EmployeeTitleController(IDbService db) => _db = db;

        // POST api/<EmployeeTitleController>
        [HttpPost]
        
            public async Task<IResult> Post([FromBody] EmployeeTitleDTO dto)
            {
                try
                {
                    var entity = await _db.AddAsync<EmployeeTitle, EmployeeTitleDTO>(dto);
                    if (await _db.SaveChangesAsync())
                    {
                        var node = typeof(EmployeeTitle).Name.ToLower();
                        return Results.Created($"/{node}s/{entity.TitleId},{entity.TitleId}", entity);
                    }

                }
                catch (Exception ex)
                {
                    return Results.BadRequest($"Couldn't add the {typeof(EmployeeTitle).Name} entity.\n{ex}.");
                }
                return Results.BadRequest($"Couldn't add the {typeof(EmployeeTitle).Name} entity.");
            }

        // DELETE api/<EmployeeTitleController>/5
        [HttpDelete()]
        public async Task<IResult> Delete(EmployeeTitleDTO dto)
        {
            try
            {
                if (!_db.Delete<EmployeeTitle, EmployeeTitleDTO>(dto)) return Results.NotFound();
                if (await _db.SaveChangesAsync()) return Results.NoContent();

            }
            catch (Exception ex)
            {
                return Results.BadRequest($"Couldn't delete the {typeof(EmployeeTitle).Name}entity.\n{ex}.");
            }
            return Results.BadRequest($"Couldn't delete the {typeof(EmployeeTitle).Name}entity.");
        }
    }
}
