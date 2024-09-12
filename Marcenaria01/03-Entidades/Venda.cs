using Dapper.Contrib.Extensions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Marcenaria01._03_Entidades
{
    [Table("Vendas")]
    public class Venda
    {
        public int Id { get; set; }
        public int DataVenda { get; set; } 
        public int ClienteId { get; set; }
        public string ItensVendidos { get; set; }
        public int TotalVendas { get; set; }
    }
}
