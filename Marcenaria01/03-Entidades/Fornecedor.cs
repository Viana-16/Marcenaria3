﻿using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcenaria._03_Entidades
{
    [Table("Fornecedores")]
    public class Fornecedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int CNPJ { get; set; } 
        public string Endereco { get; set; }
        public string Email { get; set; }
        public int Telefone { get; set; }
    }
}
