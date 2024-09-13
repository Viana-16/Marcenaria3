using API.DTO.Produto;
using AutoMapper;
using Marcenaria._01_Services;
using Marcenaria._02_Repository;
using Marcenaria._03_Entidades;
using Marcenaria01._02_Repository;
using Marcenaria01._03_Entidades;
using Marcenaria01._03_Entidades.DTO.Produto;
using Microsoft.AspNetCore.Mvc;
using System.Data.SQLite;

namespace CRUDDRAPER.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Funcionariocontroller : ControllerBase
    {
        private readonly FuncionarioRepository _repository;
        private readonly IMapper _mapper;
        public Funcionariocontroller(IConfiguration config, IMapper mapper)
        {
            string _config = config.GetConnectionString("DefaultConnection");
            _repository = new FuncionarioRepository(_config);
            _mapper = mapper;
        }
        [HttpPost("adicionar-Funcionario")]
        public void Adicionar(CreateFuncionarioDTO funcionarioDTO)
        {
            Funcionario funcionario = _mapper.Map<Funcionario>(funcionarioDTO);
            _repository.Adicionar(funcionario);
        }
        [HttpGet("listar-Funcionario")]
        public List<Funcionario> Listar()
        {
            return _repository.Listar();
        }
        [HttpPut("editar-Funcionario")]
        public void Editar(Funcionario f)
        {
            _repository.Editar(f);
        }
        [HttpDelete("deletar-Funcionario")]
        public void Deletar(int id)
        {
            _repository.Remover(id);
        }
        [HttpGet("Buscar-Funcionario-por-Id")]
        public Funcionario BuscarPorId(int id)
        {
            return _repository.BuscarPorId(id);
        }
    }
}
