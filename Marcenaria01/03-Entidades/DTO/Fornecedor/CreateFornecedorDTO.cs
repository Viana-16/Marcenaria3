﻿namespace API.DTO.Produto
{
    public class CreateFornecedorDTO
    {
        public string Nome { get; set; }
        public int CNPJ { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
        public int Telefone { get; set; }
    }
}
