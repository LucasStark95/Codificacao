using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;
using Persistencia.Persistence;

namespace Negocio.Business
{
    class GerenciadorPaciente
    {
        private RepositorioPaciente pacPersistencia;

        public GerenciadorPaciente()
        {
            pacPersistencia = new RepositorioPaciente();
        }

        public Paciente Adicionar(Paciente pac)
        {
            pacPersistencia.Adicionar(pac);
            return pac;
        }

        public void Editar(Paciente pac)
        {
            pacPersistencia.Editar(pac);
        }

        public void Remover(Paciente pac)
        {
            pacPersistencia.Remover(pac);
        }

        public Paciente Obter(int id)
        {
            return pacPersistencia.Obter(e => e.IdPaciente == id);
        }

        public List<Paciente> ObterTodos()
        {
            return pacPersistencia.ObterTodos();
        }

    }
}
