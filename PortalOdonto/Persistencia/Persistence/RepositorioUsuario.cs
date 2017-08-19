using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Persistence
{
    class RepositorioUsuario
    {
        //Creio que não seja necessario essa classe de persistencia, ja que ela é uma classe de herança para as outras
        private static List<Usuario> listaUsuarios;

        static RepositorioUsuario()
        {
            listaUsuarios = new List<Usuario>();
        }

        public Usuario Adicionar(Usuario usuario)
        {
            usuario.MatriculaUsuario = listaUsuarios.Count + 1;
            listaUsuarios.Add(usuario);
            return usuario;
        }

        public void Editar(Usuario usuario)
        {
            int posicao = listaUsuarios.FindIndex(e => e.MatriculaUsuario == usuario.MatriculaUsuario);
            listaUsuarios[posicao] = usuario;
        }

        public void Remover(Usuario usuario)
        {
            int posicao = listaUsuarios.FindIndex(e => e.MatriculaUsuario == usuario.MatriculaUsuario);
            listaUsuarios.RemoveAt(posicao);
        }

        public Usuario Obter(Func<Usuario, bool> where)
        {
            return listaUsuarios.Where(where).FirstOrDefault();
        }

        public List<Usuario> ObterTodos()
        {
            return listaUsuarios;
        }
    }
}
