using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Persistencia.Persistence
{
    class RepositorioAluno
    {
        private static List<Aluno> listaAlunos;

        static RepositorioAluno()
        {
            listaAlunos = new List<Aluno>();
        }

        public Aluno Adicionar(Aluno aluno)
        {
            aluno.MatriculaUsuario =listaAlunos.Count + 1;
            listaAlunos.Add(aluno);
            return aluno;
        }

        public void Editar(Aluno aluno)
        {
            int posicao = listaAlunos.FindIndex(e => e.MatriculaUsuario == aluno.MatriculaUsuario);
            listaAlunos[posicao] = aluno;
        }

        public void Remover(Aluno aluno)
        {
            int posicao = listaAlunos.FindIndex(e => e.MatriculaUsuario == aluno.MatriculaUsuario);
            listaAlunos.RemoveAt(posicao);
        }

        public Aluno Obter(Func<Aluno, bool> where)
        {
            return listaAlunos.Where(where).FirstOrDefault();
        }

        public List<Aluno> ObterTodos()
        {
            return listaAlunos;
        }

    }
}
