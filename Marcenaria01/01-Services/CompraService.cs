using Marcenaria._02_Repository;
using Marcenaria._03_Entidades;
using Marcenaria01._02_Repository;
using Marcenaria01._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcenaria._01_Services
{
    public class CompraService
    {
        public CompraRepository repository { get; set; }
        public CompraService(string _config)
        {
            repository = new CompraRepository(_config);
        }
        public void Adicionar(Compra compra)
        {
            repository.Adicionar(compra);
        }

        public void Remover(int id)
        {
            repository.Remover(id);
        }

        public List<Compra> Listar()
        {
            return repository.Listar();
        }
        public void BuscarPorId(int id)
        {
            //return repository.BuscarPorId(id);
        }
        public void Editar(Compra editCompra)
        {
            repository.Editar(editCompra);
        }

    }
}
