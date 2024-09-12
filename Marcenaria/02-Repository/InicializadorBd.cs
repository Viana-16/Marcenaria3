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
        public static void Inicializador()
        {
            using (var connection = new SQLiteConnection(ConnectioString))
            {
                connection.Open();
                string commandoSQL = @" 
                CREATE TABLE IF NOT EXISTS Produto(                
                ID INTEGER PRIMARY KEY AUTOINCREMENT,
                NOME TEXT NOT NULL,
                PRECO INTEGER NOT NULL,
                VALIDADE INTEGER NOT NULL,
                DESCRICAO TEXT NOT NULL,
                CATEGORIA TEXT NOT NULL,
                QUANTIDADEESTOQUE INTEGER NOT NULL
          
            );";
                using (var command = new SQLiteCommand(commandoSQL, connection))
                {
                    command.ExecuteNonQuery();
                }

            }
        }
    }
}
