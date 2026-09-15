using ClinicaApi.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ClinicaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TutoresController : ControllerBase
    {
        private readonly VetContext _context;

        public MatriculasController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Matricula>>> GetMatriculas()
        {
            return await _context.Matriculas.ToListAsync();
        }

        [HttpPost]

        public async Task<IActionResult> CriarMatricula(Matricula matricula)
        {
            _context.Matriculas.Add(matricula);
            await _context.SaveChangesAsync();
            return Ok("Matricula salvo com sucesso");
        }
    }
}
