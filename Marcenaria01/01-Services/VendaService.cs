using Marcenaria._02_Repository;
using Marcenaria._03_Entidades;
using Marcenaria01._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcenaria._01_Services
{
    public class VendaService
    {
        public VendaRepository _repository { get; set; }
        public VendaService(string _config)
        {
            _repository = new VendaRepository(_config);
        }
        public void Adicionar(Venda venda)
        {
            _repository.Adicionar(venda);
        }

        public void Remover(int id)
        {
            _repository.Remover(id);
        }

        public List<Venda> Listar()
        {
            return _repository.Listar();
        }
        public Venda BuscarPorId(int id)
        {
            return _repository.BuscarPorId(id);
        }
        public void Editar(Venda editVenda)
        {
            _repository.Editar(editVenda);
        }

    }
}

