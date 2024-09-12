using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcenaria._02_Repository
{
    public class InicializadorBd
    {
        private const string ConnectioString = "Data Source=Marcenaria.db";
        public static void Inicializar()
        {
            using (var connection = new SQLiteConnection(ConnectioString))
            {
                connection.Open();
                string commandoSQL = @" 
                CREATE TABLE IF NOT EXISTS Produtos(                
                ID INTEGER PRIMARY KEY AUTOINCREMENT,
                NOME TEXT NOT NULL,
                PRECO INTEGER NOT NULL,
                VALIDADE INTEGER NOT NULL,
                DESCRICAO TEXT NOT NULL,
                CATEGORIA TEXT NOT NULL,
                QUANTIDADEESTOQUE INTEGER NOT NULL
          
            );";

                commandoSQL += @" 
                CREATE TABLE IF NOT EXISTS Fornecedores(                
                ID INTEGER PRIMARY KEY AUTOINCREMENT,
                NOME TEXT NOT NULL,
                CNPJ INTEGER NOT NULL,
                ENDERECO TEXT NOT NULL,
                EMAIL TEXT NOT NULL,
                TELEFONE INTEGER NOT NULL
          
            );";

                commandoSQL += @" 
                CREATE TABLE IF NOT EXISTS Cliente(                
                ID INTEGER PRIMARY KEY AUTOINCREMENT,
                NOME TEXT NOT NULL,
                CONTATO INTEGER NOT NULL,
                ENDERECO TEXT NOT NULL,
                
          
            );";

                connection.Execute(commandoSQL);


            }
        }
    }
}
