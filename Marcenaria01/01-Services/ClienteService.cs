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
    public class ClienteService
    {
        public ClienteRepository _repository { get; set; }
        public ClienteService(string _config)
        {
            _repository = new ClienteRepository(_config);
        }
        public void Adicionar(Cliente clientes)
        {
            _repository.Adicionar(clientes);
        }

        public void Remover(int id)
        {
            _repository.Remover(id);
        }

        public List<Cliente> Listar()
        {
            return _repository.Listar();
        }
        public Cliente BuscarTimePorId(int id)
        {
           return _repository.BuscarPorId(id);
        }
        public void Editar(Cliente editClientes)
        {
            _repository.Editar(editClientes);
        }
       
    }
}
