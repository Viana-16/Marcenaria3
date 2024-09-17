using API.DTO.Produto;
using AutoMapper;
using Marcenaria._03_Entidades;
using Marcenaria01._01_Services;
using Marcenaria01._02_Repository;
using Marcenaria01._03_Entidades;
using Marcenaria01._03_Entidades.DTO.Produto;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class Clientecontroller : ControllerBase
    {
        private readonly ClienteService _service;
        private readonly IMapper _mapper;
        public Clientecontroller(IConfiguration config, IMapper mapper)
        {
            string _config = config.GetConnectionString("DefaultConnection");
            _service = new ClienteService(_config);
            _mapper = mapper;
        }
        [HttpPost("adicionar-Clientes")]
        public void Adicionar(CreateClienteDTO clienteDTO)
        {
            Cliente clientes = _mapper.Map<Cliente>(clienteDTO);
            _service.Adicionar(clientes);
        }
        [HttpGet("listar-Clientes")]
        public List<Cliente> Listar()
        {
            return _service.Listar();
        }
        [HttpPut("editar-Clientes")]
        public void Editar(Cliente c)
        {
            _service.Editar(c);
        }
        [HttpDelete("deletar-Clientes")]
        public void Deletar(int id)
        {
            _service.Remover(id);
        }
        [HttpGet("Buscar-Cliente-por-Id")]
        public Cliente BuscarPorId(int id)
        {
            return _service.BuscarPorId(id);
        }
    }
}

