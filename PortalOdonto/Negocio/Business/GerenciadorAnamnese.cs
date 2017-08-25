using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;
using Persistencia.Persistence;

namespace Negocio.Business
{
    class GerenciadorAnamnese
    {
        private RepositorioAnamnese anaPersistencia;

        public GerenciadorAnamnese()
        {
            anaPersistencia = new RepositorioAnamnese();
        }

        public Anamnese Adicionar(Anamnese ana)
        {
            anaPersistencia.Adicionar(ana);
            return ana;
        }

        public void Editar(Anamnese ana)
        {
            anaPersistencia.Editar(ana);
        }

        public void Remover(Anamnese ana)
        {
            anaPersistencia.Remover(ana);
        }

        public Anamnese Obter(int id)
        {
            return anaPersistencia.Obter(e => e.IdAnamnese == id);
        }

        public List<Anamnese> ObterTodos()
        {
            return anaPersistencia.ObterTodos();
        }
    }
}
