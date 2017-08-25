using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;
using Persistencia.Persistence;

namespace Negocio.Business
{
    public class GerenciadorAluno
    {
        private RepositorioAluno aluPersistencia;

        public GerenciadorAluno()
        {
            aluPersistencia = new RepositorioAluno();
        }

        public Aluno Adicionar(Aluno alu)
        {
            aluPersistencia.Adicionar(alu);
            return alu;
        }

        public void Editar(Aluno alu)
        {
            aluPersistencia.Editar(alu);
        }

        public void Remover(Aluno alu)
        {
            aluPersistencia.Remover(alu);
        }

        public Aluno Obter(int id)
        {
            return aluPersistencia.Obter(e => e.IdAluno == id);
        }

        public List<Aluno> ObterTodos()
        {
            return aluPersistencia.ObterTodos();
        }
    }
}
