using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcenaria01._03_Entidades.DTO.Produto
{
    public class CreateCompraDTO
    {
        public int DataCompra { get; set; }
        public string ItensComprados { get; set; }
        public int Total { get; set; }
    }
}
