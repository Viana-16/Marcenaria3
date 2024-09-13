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
        private readonly ProdutoRepository _repository;
        private readonly IMapper _mapper;
        public Produtocontroller(IConfiguration config, IMapper mapper)
        {
            string _config = config.GetConnectionString("DefaultConnection");
            _repository = new ProdutoRepository(_config);
            _mapper = mapper;
        }
        [HttpPost("adicionar-Produto")]
        public void Adicionar(CreateProdutosDTO produtoDTO)
        {
            Produtos produto = _mapper.Map<Produtos>(produtoDTO);
            _repository.Adicionar(produto);
        }
        [HttpGet("listar-produto")]
        public List<Produtos> Listar()
        {
            return _repository.Listar();
        }
        [HttpPut("editar-Produto")]
        public void Editar(Produtos p)
        {
            _repository.Editar(p);
        }
        [HttpDelete("deletar-Produto")]
        public void Deletar(int id)
        {
            _repository.Remover(id);
        }
        [HttpGet("Buscar-Produto-por-Id")]
        public Produtos BuscarPorId(int id)
        {
            return _repository.BuscarPorId(id);
        }
    }
}
