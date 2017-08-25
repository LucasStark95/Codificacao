using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;
using Persistencia.Persistence;

namespace Negocio.Business
{
    class GerenciadorTriagem
    {
        private RepositorioTriagem triPersistencia;

        public GerenciadorTriagem()
        {
            triPersistencia = new RepositorioTriagem();
        }

        public Triagem Adicionar(Triagem tri)
        {
            triPersistencia.Adicionar(tri);
            return tri;
        }

        public void Editar(Triagem tri)
        {
            triPersistencia.Editar(tri);
        }

        public void Remover(Triagem tri)
        {
            triPersistencia.Remover(tri);
        }

        public Triagem Obter(int id)
        {
            return triPersistencia.Obter(e => e.IdTriagem == id);
        }

        public List<Triagem> ObterTodos()
        {
            return triPersistencia.ObterTodos();
        }
    }
}
