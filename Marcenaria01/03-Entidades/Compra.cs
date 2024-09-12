using Dapper.Contrib.Extensions;
using Marcenaria._03_Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcenaria01._03_Entidades
{
    [Table("Compras")]
    public class Compra
    {
        public int Id { get; set; }
        public int DataCompra { get; set; }
        public int FornecedorId { get; set; }
        public string ItensComprados { get; set; }
        public int Total { get; set; }
    }
}
