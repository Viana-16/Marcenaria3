using Dapper.Contrib.Extensions;
using Marcenaria._03_Entidades;
using Marcenaria01._03_Entidades;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcenaria._02_Repository
{
    public class FuncionarioRepository
    {
        private readonly string ConnectionString;
        public FuncionarioRepository(string connectioString)
        {
            ConnectionString = connectioString;
        }
        public void Adicionar(Funcionario funcionario)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Funcionario>(funcionario);
        }
        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Funcionario funcionario = BuscarPorId(id);
            connection.Delete<Funcionario>(funcionario);
        }
        public void Editar(Funcionario funcionario)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Funcionario>(funcionario); 
        }
        public List<Funcionario> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Funcionario>().ToList();
        }
        public Funcionario BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Funcionario>(id);
        }
    }
}

