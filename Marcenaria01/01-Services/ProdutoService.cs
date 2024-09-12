using Marcenaria._02_Repository;
using Marcenaria._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcenaria._01_Services
{
    public class ProdutoService
    {
        public ProdutoRepository repository { get; set; }
        public ProdutoService(string _config)
        {
            repository = new ProdutoRepository(_config);
        }
        public void Adicionar(Produtos produto)
        {
            repository.Adicionar(produto);
        }

        public void Remover(int id)
        {
            repository.Remover(id);
        }

        public List<Produtos> Listar()
        {
            return repository.Listar();
        }
        public void BuscarTimePorId(int id)
        {
            //return repository.BuscarPorId(id);
        }
        public void Editar( Produtos editProduto)
        {
            repository.Editar( editProduto);
        }

    }
}
