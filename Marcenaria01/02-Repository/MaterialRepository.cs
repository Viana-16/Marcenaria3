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
    public class MaterialRepository
    {
        private readonly string ConnectionString;
        public MaterialRepository(string connectioString)
        {
            ConnectionString = connectioString;
        }
        public void Adicionar(Material material)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Material>(material);
        }
        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Material material = BuscarPorId(id);
            connection.Delete<Material>(material);
        }
        public void Editar(Material material)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Material>(material);
        }
        public List<Material> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Material>().ToList();
        }
        public Material BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Material>(id);
        }
    }
}

