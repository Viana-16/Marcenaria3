﻿using Marcenaria._02_Repository;
using Marcenaria._03_Entidades;
using Marcenaria01._02_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcenaria01._01_Services
{
    public class FornecedorService
    {
        public FornecedorRepository _repository { get; set; }
        public FornecedorService(string _config)
        {
            _repository = new FornecedorRepository(_config);
        }
        public void Adicionar(Fornecedor fornecedor)
        {
            _repository.Adicionar(fornecedor);
        }

        public void Remover(int id)
        {
            _repository.Remover(id);
        }

        public List<Fornecedor> Listar()
        {
            return _repository.Listar();
        }
        public Fornecedor BuscarPorId(int id)
        {
           return _repository.BuscarPorId(id);
        }
        public void Editar(Fornecedor editFornecedor)
        {
            _repository.Editar(editFornecedor);
        }

    }
}

