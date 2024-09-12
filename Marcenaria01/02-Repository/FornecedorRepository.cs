using Dapper.Contrib.Extensions;
using Marcenaria._03_Entidades;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcenaria01._02_Repository
{
    public class FornecedorRepository
    {
        private readonly string ConnectionString;
        public FornecedorRepository(string connectioString)
        {
            ConnectionString = connectioString;
        }
        public void Adicionar(Fornecedor fornecedor)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Fornecedor>(fornecedor);
        }
        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Fornecedor fornecedor = BuscarPorId(id);
            connection.Delete<Fornecedor>(fornecedor);
        }
        public void Editar(Fornecedor fornecedor)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Fornecedor>(fornecedor);
        }
        public List<Fornecedor> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Fornecedor>().ToList();
        }
        public Fornecedor BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Fornecedor>(id);
        }
    }
}
