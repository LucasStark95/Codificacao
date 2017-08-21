using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;
using Persistencia.Persistence;

namespace Negocio.Business
{
    public class GerenciadorAdministrador
    {
        
            private RepositorioAdministrador admPersistencia;

            public GerenciadorAdministrador()
            {
            admPersistencia = new RepositorioAdministrador();
            }

            public Administrador Adicionar(Administrador adm)
            {
            admPersistencia.Adicionar(adm);
                return adm;
            }

            public void Editar(Administrador adm)
            {
            admPersistencia.Editar(adm);
            }

            public void Remover(Administrador adm)
            {
            admPersistencia.Remover(adm);
            }

            public Administrador Obter(int id)
            {
                return admPersistencia.Obter(e => e.IdAdministrador == id);
            }

            public List<Administrador> ObterTodos()
            {
                return admPersistencia.ObterTodos();
            }
        
    }
}
