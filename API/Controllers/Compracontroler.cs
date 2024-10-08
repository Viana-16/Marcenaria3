﻿using API.DTO.Produto;
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
    public class Compracontroller : ControllerBase
    {
        private readonly CompraService _service;
        private readonly IMapper _mapper;
        public Compracontroller(IConfiguration config, IMapper mapper)
        {
            string _config = config.GetConnectionString("DefaultConnection");
            _service = new CompraService(_config);
            _mapper = mapper;
        }
        [HttpPost("adicionar-Compra")]
        public void Adicionar(CreateCompraDTO compraDTO)
        {
            Compra compra = _mapper.Map<Compra>(compraDTO);
            _service.Adicionar(compra);
        }
        [HttpGet("listar-Compra")]
        public List<Compra> Listar()
        {
            return _service.Listar();
        }
        [HttpPut("editar-Compra")]
        public void Editar(Compra c)
        {
            _service.Editar(c);
        }
        [HttpDelete("deletar-Compra")]
        public void Deletar(int id)
        {
            _service.Remover(id);
        }
        [HttpGet("Buscar-Compra-por-Id")]
        public Compra BuscarPorId(int id)
        {
            return _service.BuscarPorId(id);
        }
    }
}
