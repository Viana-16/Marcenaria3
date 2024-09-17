using Marcenaria._02_Repository;
using Marcenaria._03_Entidades;
using Marcenaria01._02_Repository;
using Marcenaria01._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcenaria._01_Services
{
    public class FuncionarioService
    {
        public FuncionarioRepository _repository { get; set; }
        public FuncionarioService(string _config)
        {
            _repository = new FuncionarioRepository(_config);
        }
        public void Adicionar(Funcionario funcionario)
        {
            _repository.Adicionar(funcionario);
        }

        public void Remover(int id)
        {
            _repository.Remover(id);
        }

        public List<Funcionario> Listar()
        {
            return _repository.Listar();
        }
        public Funcionario BuscarPorId(int id)
        {
           return _repository.BuscarPorId(id);
        }
        public void Editar(Funcionario editFuncionario)
        {
            _repository.Editar(editFuncionario);
        }

    }
}