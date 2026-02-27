using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MinhaPrimeiraApiCrud.Data;
using MinhaPrimeiraApiCrud.Models;

namespace MinhaPrimeiraApiCrud.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PessoaController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PessoaController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Pessoa
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var pessoas = await _context.Pessoas.ToListAsync();
            return Ok(pessoas);
        }

        // POST: api/Pessoa
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Pessoa pessoa)
        {
            _context.Pessoas.Add(pessoa);
            await _context.SaveChangesAsync();
            return Ok(pessoa);
        }

        // PUT: api/Pessoa/1
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Pessoa pessoaAtualizada)
        {
            var pessoa = await _context.Pessoas.FirstOrDefaultAsync(p => p.Id == id);
            if (pessoa == null)
                return NotFound("Pessoa não encontrada");

            pessoa.Nome = pessoaAtualizada.Nome;
            pessoa.Idade = pessoaAtualizada.Idade;

            await _context.SaveChangesAsync();
            return Ok(pessoa);
        }

        // DELETE: api/Pessoa/1
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var pessoa = await _context.Pessoas.FirstOrDefaultAsync(p => p.Id == id);
            if (pessoa == null)
                return NotFound("Pessoa não encontrada");

            _context.Pessoas.Remove(pessoa);
            await _context.SaveChangesAsync();

            return Ok("Pessoa removida com sucesso");
        }
    }
}