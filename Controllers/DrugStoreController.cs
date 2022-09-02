using DataAccess;
using DrugStroreAppFull.Models;
using DrugStroreAppFull.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DrugStroreAppFull.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrugStoreController : ControllerBase
    {
        private readonly IGenericCRUDService<DrugStoreModel> _storeSvc;
        public DrugStoreController(IGenericCRUDService<DrugStoreModel> storeSvc)
        {
            _storeSvc = storeSvc;
        }

        // GET: api/<DrugStoreController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _storeSvc.GetAll());
        }

        // GET api/<DrugStoreController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            if (id <= 0)
                return BadRequest($"id does not support {id}!");
            return Ok(await _storeSvc.GetById(id));
        }

        // POST api/<DrugStoreController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] DrugStoreModel model)
        {
            var store = await _storeSvc.Create(model);
            var route = new { id = store.Id };
            return CreatedAtRoute(route, store);
        }

        // PUT api/<DrugStoreController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] DrugStoreModel model)
        {
            var update = await _storeSvc.Update(id, model);
            return Ok(update);
        }

        // DELETE api/<DrugStoreController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var value = await _storeSvc.Delete(id);
            if(value)
                return Ok(value);
            return NotFound();
        }
    }
}
