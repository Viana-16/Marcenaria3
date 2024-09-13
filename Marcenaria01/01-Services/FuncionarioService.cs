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
        public FuncionarioRepository repository { get; set; }
        public FuncionarioService(string _config)
        {
            repository = new FuncionarioRepository(_config);
        }
        public void Adicionar(Funcionario funcionario)
        {
            repository.Adicionar(funcionario);
        }

        public void Remover(int id)
        {
            repository.Remover(id);
        }

        public List<Funcionario> Listar()
        {
            return repository.Listar();
        }
        public void BuscarPorId(int id)
        {
            //return repository.BuscarPorId(id);
        }
        public void Editar(Funcionario editFuncionario)
        {
            repository.Editar(editFuncionario);
        }

    }
}