using AutoMapper;
using LogisticaLoremIpsum.Data;
using LogisticaLoremIpsum.Data.Dtos;
using LogisticaLoremIpsum.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace LogisticaLoremIpsum.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase

    {
        private ClienteContext _context;
        private IMapper _mapper;

        public ClienteController(ClienteContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult adicionarCliente([FromBody] CreateClienteDto clienteDto)
        {
            Cliente cliente = _mapper.Map<Cliente>(clienteDto);

            _context.Cliente.Add(cliente);
            _context.SaveChanges();
            return CreatedAtAction(nameof(listarClienteId), new { id = cliente.id }, cliente);
        }
        
        [HttpGet]
        public IEnumerable<Cliente> listarClientes()
        {
            return _context.Cliente;
        }
       
        [HttpGet("{id}")]
        public IActionResult listarClienteId(int id)
        {
            Cliente cliente = _context.Cliente.FirstOrDefault(cliente => cliente.id == id);
            if(cliente != null)
            {
                ReadClienteDto clienteDto = _mapper.Map<ReadClienteDto>(cliente);
                return Ok(cliente);
            }         
            return NotFound();
            
        }
        [HttpPut("{id}")]
        public IActionResult atualizaCliente(int id, [FromBody] UpdateClienteDto clienteDto)
        {
            Cliente cliente = _context.Cliente.FirstOrDefault(cliente => cliente.id == id);
            if(cliente == null)
            {
                return NotFound();
            }

            _mapper.Map(clienteDto, cliente);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult deletarCliente(int id)
        {
            Cliente cliente = _context.Cliente.FirstOrDefault(cliente => cliente.id == id);
            if (cliente == null)
            {
                return NotFound();
            }
            _context.Remove(cliente);
            _context.SaveChanges();
            return NoContent();
        }
        
    }
}
