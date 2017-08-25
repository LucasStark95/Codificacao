using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;
using Persistencia.Persistence;

namespace Negocio.Business
{
    class GerenciadorProntuario
    {
        private RepositorioProntuario proPersistencia;

        public GerenciadorProntuario()
        {
            proPersistencia = new RepositorioProntuario();
        }

        public Prontuario Adicionar(Prontuario pro)
        {
            proPersistencia.Adicionar(pro);
            return pro;
        }

        public Prontuario Obter(int id)
        {
            return proPersistencia.Obter(e => e.IdProntuario == id);
        }

        public List<Prontuario> ObterTodos()
        {
            return proPersistencia.ObterTodos();
        }
    }
}
