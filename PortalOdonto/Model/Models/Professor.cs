
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Models
{
    public class Professor : Usuario
    {

        private int idProfessor;

        public Professor()
        {
        }

        public int IdProfessor
        {
            get { return idProfessor; }
            set { idProfessor = value; }
        }
    }
}