using API.DTO.Produto;
using AutoMapper;
using Marcenaria01._02_Repository;
using Marcenaria01._03_Entidades.DTO.Produto;
using Marcenaria01._03_Entidades;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class Compracontroller : ControllerBase
    {
       
            private readonly CompraRepository _repository;
            private readonly IMapper _mapper;
            public Compracontroller(IConfiguration config, IMapper mapper)
            {
                string _config = config.GetConnectionString("DefaultConnection");
                _repository = new CompraRepository(_config);
                _mapper = mapper;
            }
            [HttpPost("adicionar-Compras")]
            public void Adicionar(CreateCompraDTO compraDTO)
            {
                Compra compra = _mapper.Map<Compra>(compraDTO);
                _repository.Adicionar(compra);
            }
            [HttpGet("listar-Compras")]
            public List<Compra> Listar()
            {
                return _repository.Listar();
            }
            [HttpPut("editar-Compras")]
            public void Editar(Compra c)
            {
                _repository.Editar(c);
            }
            [HttpDelete("deletar-Compras")]
            public void Deletar(int id)
            {
                _repository.Remover(id);
            }
            [HttpGet("Buscar-Compra-por-Id")]
            public Compra BuscarPorId(int id)
            {
                return _repository.BuscarPorId(id);
            }
    }
    }


