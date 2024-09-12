using API.DTO.Produto;
using AutoMapper;
using Marcenaria._01_Services;
using Marcenaria._02_Repository;
using Marcenaria._03_Entidades;
using Microsoft.AspNetCore.Mvc;
using System.Data.SQLite;

namespace CRUDDRAPER.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Produtocontroller : ControllerBase
    {
        private readonly ProdutoService _service;
        private readonly IMapper _mapper;
        public Produtocontroller(IConfiguration config, IMapper mapper)
        {
            string _config = config.GetConnectionString("DefaultConnection");
            _service = new ProdutoService(_config);
            _mapper = mapper;
        }
        [HttpPost("adicionar-Produto")]
        public void AdicionarProduto(CreateProdutosDTO produtoDTO)
        {
            Produtos produto = _mapper.Map<Produtos>(produtoDTO);
            _service.Adicionar(produto);
        }
        [HttpGet("listar-produto")]
        public List<Produtos> ListarProduto()
        {
            return _service.Listar();
        }
        [HttpPut("editar-Produto")]
        public void EditarProduto(Produtos p)
        {
            _service.Editar(p);
        }
        [HttpDelete("deletar-Produto")]
        public void DeletarProduto(int id)
        {
            _service.Remover(id);
        }
    }
}
