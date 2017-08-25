using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;
using Persistencia.Persistence;

namespace Negocio.Business
{
    public class GerenciadorProfessor
    {
        private RepositorioProfessor proPersistencia;

        public GerenciadorProfessor()
        {
            proPersistencia = new RepositorioProfessor();
        }

        public Professor Adicionar(Professor pro)
        {
            proPersistencia.Adicionar(pro);
            return pro;
        }

        public void Editar(Professor pro)
        {
            proPersistencia.Editar(pro);
        }

        public void Remover(Professor pro)
        {
            proPersistencia.Remover(pro);
        }

        public Professor Obter(int id)
        {
            return proPersistencia.Obter(e => e.IdProfessor == id);
        }

        public List<Professor> ObterTodos()
        {
            return proPersistencia.ObterTodos();
        }

    }
}
