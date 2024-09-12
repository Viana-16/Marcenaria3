using API.DTO.Produto;
using AutoMapper;
using Marcenaria._03_Entidades;
using Marcenaria01._01_Services;
using Marcenaria01._03_Entidades;
using Marcenaria01._03_Entidades.DTO.Produto;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class Clientecontroller : Controller
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
        public void AdicionarCliente(CreateClienteDTO clienteDTO)
        {
            Cliente clientes = _mapper.Map<Cliente>(clienteDTO);
            _service.Adicionar(clientes);
        }
        [HttpGet("listar-Clientes")]
        public List<Cliente> ListarCliente()
        {
            return _service.Listar();
        }
        [HttpPut("editar-Clientes")]
        public void EditarCliente(Cliente c)
        {
            _service.Editar(c);
        }
        [HttpDelete("deletar-Clientes")]
        public void DeletarCliente(int id)
        {
            _service.Remover(id);
        }
    }
}

