using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Persistence
{
    class RepositorioTriagem
    {
        private static List<Triagem> listaTriagens;

        static RepositorioTriagem()
        {
            listaTriagens = new List<Triagem>();
        }

        public Triagem Adicionar(Triagem triagem)
        {
            triagem.Id = listaTriagens.Count + 1;
            listaTriagens.Add(triagem);
            return triagem;
        }

        public void Editar(Triagem triagem)
        {
            int posicao = listaTriagens.FindIndex(e => e.Id == triagem.Id);
            listaTriagens[posicao] = triagem;
        }

        public void Remover(Triagem triagem)
        {
            int posicao = listaTriagens.FindIndex(e => e.Id == triagem.Id);
            listaTriagens.RemoveAt(posicao);
        }

        public Triagem Obter(Func<Triagem, bool> where)
        {
            return listaTriagens.Where(where).FirstOrDefault();
        }

        public List<Triagem> ObterTodos()
        {
            return listaTriagens;
        }
    }
}
