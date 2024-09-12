using Dapper.Contrib.Extensions;
using Marcenaria._03_Entidades;
using Marcenaria01._03_Entidades;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcenaria01._02_Repository
{
    public class ClienteRepository
    {
        private readonly string ConnectionString;
        public ClienteRepository(string connectioString)
        {
            ConnectionString = connectioString;
        }
        public void Adicionar(Cliente clientes)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Cliente>(clientes);
        }
        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Cliente clientes = BuscarPorId(id);
            connection.Delete<Cliente>(clientes);
        }
        public void Editar(Cliente clientes)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Cliente>(clientes);
        }
        public List<Cliente> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Cliente>().ToList();
        }
        public Cliente BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Cliente>(id);
        }
    }
}
