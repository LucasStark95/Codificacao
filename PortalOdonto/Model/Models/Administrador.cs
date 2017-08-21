
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Models
{
    public class Administrador : Usuario
    {

        private int idAdministrador;

        public Administrador()
        {
        }

        public int IdAdministrador
        {
            get { return idAdministrador; }
            set { idAdministrador = value; }
        }


        public void CadProf()
        {

        }


        public void CadTec()
        {

        }


        public void CadAlun()
        {

        }
    }
}