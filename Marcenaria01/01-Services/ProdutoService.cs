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
        public ProdutoRepository _repository { get; set; }
        public ProdutoService(string _config)
        {
            _repository = new ProdutoRepository(_config);
        }
        public void Adicionar(Produtos produto)
        {
            _repository.Adicionar(produto);
        }

        public void Remover(int id)
        {
           _repository.Remover(id);
        }

        public List<Produtos> Listar()
        {
            return _repository.Listar();
        }
        public Produtos BuscarPorId(int id)
        {
            return _repository.BuscarPorId(id);
        }
        public void Editar( Produtos editProduto)
        {
            _repository.Editar( editProduto);
        }

    }
}
