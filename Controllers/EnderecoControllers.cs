using Microsoft.AspNetCore.Mvc;
using MinhaPrimeiraApiCrud.Data;
using MinhaPrimeiraApiCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace MinhaPrimeiraApiCrud.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EnderecoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EnderecoController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Endereco endereco)
        {
            _context.Enderecos.Add(endereco);
            await _context.SaveChangesAsync();

            return Ok(endereco);
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var enderecos = await _context.Enderecos
                .Include(e => e.Pessoa)
                .ToListAsync();

            return Ok(enderecos);
        }
    }
}