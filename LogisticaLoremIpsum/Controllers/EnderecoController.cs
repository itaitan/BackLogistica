using AutoMapper;
using LogisticaLoremIpsum.Data;
using LogisticaLoremIpsum.Data.Dtos.Enderecos;
using LogisticaLoremIpsum.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace LogisticaLoremIpsum.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnderecoController : ControllerBase

    {
        private ClienteContext _context;
        private IMapper _mapper;

        public EnderecoController(ClienteContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult adicionarEndereco([FromBody] CreateEnderecoDto enderecoDto)
        {
            Endereco endereco = _mapper.Map<Endereco>(enderecoDto);
            
            _context.Endereco.Add(endereco);
            _context.SaveChanges();
            return CreatedAtAction(nameof(listarEnderecoId), new { id = endereco.id }, endereco);
        }
        
        [HttpGet]
        public IEnumerable<Endereco> listarEnderecos()
        {
            return _context.Endereco;
        }
       
        [HttpGet("{id}")]
        public IActionResult listarEnderecoId(int id)
        {
            Endereco endereco = _context.Endereco.FirstOrDefault(endereco => endereco.id == id);
            if(endereco != null)
            {
                ReadEnderecoDto enderecoDto = _mapper.Map<ReadEnderecoDto>(endereco);
                return Ok(endereco);
            }         
            return NotFound();
            
        }
        [HttpPut("{id}")]
        public IActionResult atualizaEndereco(int id, [FromBody] UpdateEnderecoDto enderecoDto)
        {
            Endereco endereco = _context.Endereco.FirstOrDefault(endereco => endereco.id == id);
            if(endereco == null)
            {
                return NotFound();
            }

            _mapper.Map(enderecoDto, endereco);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult deletarEndereco(int id)
        {
            Endereco endereco = _context.Endereco.FirstOrDefault(endereco => endereco.id == id);
            if (endereco == null)
            {
                return NotFound();
            }
            _context.Remove(endereco);
            _context.SaveChanges();
            return NoContent();
        }
        
    }
}
