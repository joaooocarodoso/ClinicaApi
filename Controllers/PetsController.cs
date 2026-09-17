using ClinicaApi.Data;
using ClinicaApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClinicaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        private readonly VetContext _context;

        public PetsController(VetContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pet>>> GetPets()
        {
            return await _context.Pets.ToListAsync();
        }

        [HttpPost]

        public async Task<IActionResult> CriarPet(Pet tpet)
        {
            _context.Pets.Add(tpet);
            await _context.SaveChangesAsync();
            return Ok("Pet salvo com sucesso");
        }
    }
}
