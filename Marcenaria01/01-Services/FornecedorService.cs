using Marcenaria._02_Repository;
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
        public FornecedorRepository repository { get; set; }
        public FornecedorService(string _config)
        {
            repository = new FornecedorRepository(_config);
        }
        public void Adicionar(Fornecedor fornecedor)
        {
            repository.Adicionar(fornecedor);
        }

        public void Remover(int id)
        {
            repository.Remover(id);
        }

        public List<Fornecedor> Listar()
        {
            return repository.Listar();
        }
        public void BuscarPorId(int id)
        {
            //return repository.BuscarPorId(id);
        }
        public void Editar(Fornecedor editFornecedor)
        {
            repository.Editar(editFornecedor);
        }

    }
}

