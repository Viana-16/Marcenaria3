using API.DTO.Produto;
using AutoMapper;
using Marcenaria._01_Services;
using Marcenaria._02_Repository;
using Marcenaria._03_Entidades;
using Marcenaria01._01_Services;
using Marcenaria01._02_Repository;
using Marcenaria01._03_Entidades;
using Marcenaria01._03_Entidades.DTO.Produto;
using Microsoft.AspNetCore.Mvc;
using System.Data.SQLite;

namespace CRUDDRAPER.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Materialcontroller : ControllerBase
    {
        private readonly MaterialService _service;
        private readonly IMapper _mapper;
        public Materialcontroller(IConfiguration config, IMapper mapper)
        {
            string _config = config.GetConnectionString("DefaultConnection");
            _service = new MaterialService(_config);
            _mapper = mapper;
        }
        [HttpPost("adicionar-Material")]
        public void Adicionar(CreateMaterialDTO materialDTO)
        {
            Material material = _mapper.Map<Material>(materialDTO);
            _service.Adicionar(material);
        }
        [HttpGet("listar-Material")]
        public List<Material> Listar()
        {
            return _service.Listar();
        }
        [HttpPut("editar-Material")]
        public void Editar(Material m)
        {
            _service.Editar(m);
        }
        [HttpDelete("deletar-Material")]
        public void Deletar(int id)
        {
            _service.Remover(id);
        }
        [HttpGet("Buscar-Material-por-Id")]
        public Material BuscarPorId(int id)
        {
            return _service.BuscarPorId(id);
        }
    }
}
