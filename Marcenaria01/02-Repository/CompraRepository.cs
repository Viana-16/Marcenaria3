using Dapper.Contrib.Extensions;
using Marcenaria01._03_Entidades;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcenaria01._02_Repository
{
    public class CompraRepository
    {
        private readonly string ConnectionString;
        public CompraRepository(string connectioString)
        {
            ConnectionString = connectioString;
        }
        public void Adicionar(Compra compra)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Compra>(compra);
        }
        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Compra compra = BuscarPorId(id);
            connection.Delete<Compra>(compra);
        }
        public void Editar(Compra compra)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Compra>(compra);
        }
        public List<Compra> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Compra>().ToList();
        }
        public Compra BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Compra>(id);
        }
    }
}
