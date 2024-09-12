using API.DTO.Produto;
using AutoMapper;
using Marcenaria._01_Services;
using Marcenaria._03_Entidades;
using Marcenaria01._01_Services;
using Microsoft.AspNetCore.Mvc;

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
        public void AdicionarFornecedor(CreateFornecedorDTO fornecedorDTO)
        {
            Fornecedor produto = _mapper.Map<Fornecedor>(fornecedorDTO);
            _service.Adicionar(produto);
        }
        [HttpGet("listar-Fornecedor")]
        public List<Fornecedor> ListarFornecedor()
        {
            return _service.Listar();
        }
        [HttpPut("editar-Fornecedor")]
        public void EditarFornecedor(Fornecedor f)
        {
            _service.Editar(f);
        }
        [HttpDelete("deletar-Fornecedor")]
        public void DeletarFornecedor(int id)
        {
            _service.Remover(id);
        }
    }
    

    
}
