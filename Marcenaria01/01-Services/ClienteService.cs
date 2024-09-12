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
        public ClienteRepository repository { get; set; }
        public ClienteService(string _config)
        {
            repository = new ClienteRepository(_config);
        }
        public void Adicionar(Cliente clientes)
        {
            repository.Adicionar(clientes);
        }

        public void Remover(int id)
        {
            repository.Remover(id);
        }

        public List<Cliente> Listar()
        {
            return repository.Listar();
        }
        public void BuscarTimePorId(int id)
        {
            //return repository.BuscarPorId(id);
        }
        public void Editar(Cliente editClientes)
        {
            repository.Editar(editClientes);
        }
    }
}
