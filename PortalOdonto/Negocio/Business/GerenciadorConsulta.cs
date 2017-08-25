using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;
using Persistencia.Persistence;

namespace Negocio.Business
{
    public class GerenciadorConsulta
    {
        private RepositorioConsulta conPersistencia;

        public GerenciadorConsulta()
        {
            conPersistencia = new RepositorioConsulta();
        }

        public Consulta_M Adicionar(Consulta_M con)
        {
            conPersistencia.Adicionar(con);
            return con;
        }

        public void Editar(Consulta_M pac)
        {
            conPersistencia.Editar(pac);
        }

        public void Remover(Consulta_M pac)
        {
            conPersistencia.Remover(pac);
        }

        public Consulta_M Obter(int id)
        {
            return conPersistencia.Obter(e => e.IdConsulta == id);
        }

        public List<Consulta_M> ObterTodos()
        {
            return conPersistencia.ObterTodos();
        }

    }
}
