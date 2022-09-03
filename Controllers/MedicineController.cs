using DrugStroreAppFull.Models;
using DrugStroreAppFull.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DrugStroreAppFull.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicineController : ControllerBase
    {
        private readonly IGenericCRUDService<MedicineModel> _medicineSvc;
        public MedicineController(IGenericCRUDService<MedicineModel> medicineSvc)
        {
            _medicineSvc = medicineSvc;
        }
        // GET: api/<MedicineController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _medicineSvc.GetAll());
        }

        // GET api/<MedicineController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            if (id <= 0) return BadRequest($"Employee with given id: {id} is not found");
            return Ok(await _medicineSvc.GetById(id));
        }

        // POST api/<MedicineController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] MedicineModel model)
        {
            var medicine = await _medicineSvc.Create(model);
            var route = new {id = medicine.Id};
            return CreatedAtRoute(route, medicine);
        }

        // PUT api/<MedicineController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] MedicineModel value)
        {
            var updatedMedicine = await _medicineSvc.Update(id, value);
            return Ok(updatedMedicine);
        }

        // DELETE api/<MedicineController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var delete =  await _medicineSvc.Delete(id);
            return Ok(delete);
        }
    }
}
