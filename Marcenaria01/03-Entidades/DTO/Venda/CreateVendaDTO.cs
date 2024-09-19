using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcenaria01._03_Entidades.DTO.Venda
{
    public class CreateVendaDTO
    {
        public int DataVenda { get; set; }
        public string ItensVendidos { get; set; }
        public int TotalVendas { get; set; }
    }
}
