using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcenaria01._03_Entidades.DTO.Produto
{
    public class CreateFuncionarioDTO
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public int Contato { get; set; }
        public int DataContratacao { get; set; }
    }
}
