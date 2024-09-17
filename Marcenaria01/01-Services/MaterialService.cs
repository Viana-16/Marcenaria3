using Marcenaria._02_Repository;
using Marcenaria._03_Entidades;
using Marcenaria01._02_Repository;
using Marcenaria01._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcenaria01._01_Services
{
    public class MaterialService
    {
        public MaterialRepository _repository { get; set; }
        public MaterialService(string _config)
        {
            _repository = new MaterialRepository(_config);
        }
        public void Adicionar(Material material)
        {
            _repository.Adicionar(material);
        }

        public void Remover(int id)
        {
            _repository.Remover(id);
        }

        public List<Material> Listar()
        {
            return _repository.Listar();
        }
        public Material BuscarPorId(int id)
        {
           return _repository.BuscarPorId(id);
        }
        public void Editar(Material editMaterial)
        {
            _repository.Editar(editMaterial);
        }

    }
}

