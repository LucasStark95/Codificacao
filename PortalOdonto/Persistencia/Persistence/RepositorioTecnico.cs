using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Persistence
{
    class RepositorioTecnico
    {
        private static List<Tecnico> listaTecnicos;

        static RepositorioTecnico()
        {
            listaTecnicos = new List<Tecnico>();
        }

        public Tecnico Adicionar(Tecnico tecnico)
        {
            tecnico.MatriculaUsuario = listaTecnicos.Count + 1;
            listaTecnicos.Add(tecnico);
            return tecnico;
        }

        public void Editar(Tecnico tecnico)
        {
            int posicao = listaTecnicos.FindIndex(e => e.MatriculaUsuario == tecnico.MatriculaUsuario);
            listaTecnicos[posicao] = tecnico;
        }

        public void Remover(Tecnico tecnico)
        {
            int posicao = listaTecnicos.FindIndex(e => e.MatriculaUsuario == tecnico.MatriculaUsuario);
            listaTecnicos.RemoveAt(posicao);
        }

        public Tecnico Obter(Func<Tecnico, bool> where)
        {
            return listaTecnicos.Where(where).FirstOrDefault();
        }

        public List<Tecnico> ObterTodos()
        {
            return listaTecnicos;
        }
    }
}
