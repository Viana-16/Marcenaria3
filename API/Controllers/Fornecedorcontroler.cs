using API.DTO.Produto;
using AutoMapper;
using Marcenaria._01_Services;
using Marcenaria._03_Entidades;
using Marcenaria01._01_Services;
using Marcenaria01._02_Repository;
using Marcenaria01._03_Entidades.DTO.Produto;
using Marcenaria01._03_Entidades;
using Microsoft.AspNetCore.Mvc;
using Marcenaria._02_Repository;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Fornecedorcontroller : ControllerBase
    {
        private readonly FornecedorService _service;
        private readonly IMapper _mapper;
        public Fornecedorcontroller(IConfiguration config, IMapper mapper)
        {
            string _config = config.GetConnectionString("DefaultConnection");
            _service = new FornecedorService(_config);
            _mapper = mapper;
        }
        [HttpPost("adicionar-Fornecedor")]
        public void Adicionar(CreateFornecedorDTO fornecedorDTO)
        {
            Fornecedor fornecedor = _mapper.Map<Fornecedor>(fornecedorDTO);
            _service.Adicionar(fornecedor);
        }
        [HttpGet("listar-Fornecedor")]
        public List<Fornecedor> Listar()
        {
            return _service.Listar();
        }
        [HttpPut("editar-Fornecedor")]
        public void Editar(Fornecedor f)
        {
            _service.Editar(f);
        }
        [HttpDelete("deletar-Fornecedor")]
        public void Deletar(int id)
        {
            _service.Remover(id);
        }
        [HttpGet("Buscar-Fornecedor-por-Id")]
        public Fornecedor BuscarPorId(int id)
        {
            return _service.BuscarPorId(id);
        }
    }
    

    
}
