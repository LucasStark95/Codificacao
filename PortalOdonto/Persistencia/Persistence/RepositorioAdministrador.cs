using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Persistence
{
    class RepositorioAdministrador
    {
        private static List<Administrador> listaAdministradores;

        static RepositorioAdministrador()
        {
            listaAdministradores = new List<Administrador>();
        }

        public Administrador Adicionar(Administrador administrador)
        {
            administrador.MatriculaUsuario = listaAdministradores.Count + 1;
            listaAdministradores.Add(administrador);
            return administrador;
        }

        public void Editar(Administrador administrador)
        {
            int posicao = listaAdministradores.FindIndex(e => e.MatriculaUsuario == administrador.MatriculaUsuario);
            listaAdministradores[posicao] = administrador;
        }

        public void Remover(Administrador administrador)
        {
            int posicao = listaAdministradores.FindIndex(e => e.MatriculaUsuario == administrador.MatriculaUsuario);
            listaAdministradores.RemoveAt(posicao);
        }

        public Administrador Obter(Func<Administrador, bool> where)
        {
            return listaAdministradores.Where(where).FirstOrDefault();
        }

        public List<Administrador> ObterTodos()
        {
            return listaAdministradores;
        }
    }
}
