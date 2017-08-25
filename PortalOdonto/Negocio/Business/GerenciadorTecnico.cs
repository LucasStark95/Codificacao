using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;
using Persistencia.Persistence;

namespace Negocio.Business
{
    public class GerenciadorTecnico
    {
        private RepositorioTecnico tecPersistencia;

        public GerenciadorTecnico()
        {
            tecPersistencia = new RepositorioTecnico();
        }

        public Tecnico Adicionar(Tecnico tec)
        {
            tecPersistencia.Adicionar(tec);
            return tec;
        }

        public void Editar(Tecnico tec)
        {
            tecPersistencia.Editar(tec);
        }

        public void Remover(Tecnico tec)
        {
            tecPersistencia.Remover(tec);
        }

        public Tecnico Obter(int id)
        {
            return tecPersistencia.Obter(e => e.IdTecnico == id);
        }

        public List<Tecnico> ObterTodos()
        {
            return tecPersistencia.ObterTodos();
        }
    }
}
