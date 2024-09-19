using API.DTO.Produto;
using AutoMapper;
using Marcenaria._01_Services;
using Marcenaria._02_Repository;
using Marcenaria._03_Entidades;
using Marcenaria01._03_Entidades;
using Marcenaria01._03_Entidades.DTO.Venda;
using Microsoft.AspNetCore.Mvc;
using System.Data.SQLite;

namespace CRUDDRAPER.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Vendacontroller : ControllerBase
    {
        private readonly VendaService _service;
        private readonly IMapper _mapper;
        public Vendacontroller(IConfiguration config, IMapper mapper)
        {
            string _config = config.GetConnectionString("DefaultConnection");
            _service = new VendaService(_config);
            _mapper = mapper;
        }
        [HttpPost("adicionar-Venda")]
        public void Adicionar(CreateVendaDTO VendaDTO)
        {
            Venda venda = _mapper.Map<Venda>(VendaDTO);
            _service.Adicionar(venda);
        }
        [HttpGet("listar-Venda")]
        public List<Venda> Listar()
        {
            return _service.Listar();
        }
        [HttpPut("editar-Venda")]
        public void Editar(Venda v)
        {
            _service.Editar(v);
        }
        [HttpDelete("deletar-Venda")]
        public void Deletar(int id)
        {
            _service.Remover(id);
        }
        [HttpGet("Buscar-Venda-por-Id")]
        public Venda BuscarPorId(int id)
        {
            return _service.BuscarPorId(id);
        }
    }
}
