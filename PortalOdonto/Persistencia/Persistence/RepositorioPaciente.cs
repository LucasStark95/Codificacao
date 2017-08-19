using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Persistence
{
    class RepositorioPaciente
    {
        private static List<Paciente> listaPacientes;

        static RepositorioPaciente()
        {
            listaPacientes = new List<Paciente>();
        }

        public Paciente Adicionar(Paciente paciente)
        {
            paciente.Id = listaPacientes.Count + 1;
            listaPacientes.Add(paciente);
            return paciente;
        }

        public void Editar(Paciente paciente)
        {
            int posicao = listaPacientes.FindIndex(e => e.Id == paciente.Id);
            listaPacientes[posicao] = paciente;
        }

        public void Remover(Paciente paciente)
        {
            int posicao = listaPacientes.FindIndex(e => e.Id == paciente.Id);
            listaPacientes.RemoveAt(posicao);
        }

        public Paciente Obter(Func<Paciente, bool> where)
        {
            return listaPacientes.Where(where).FirstOrDefault();
        }

        public List<Paciente> ObterTodos()
        {
            return listaPacientes;
        }

    }
}
}
