
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Models
{
    public class Aluno : Usuario
    {
#region atributos 

        private int ciclo;
        private int idAluno;
#endregion
        public Aluno()
        {
        }


        public int Ciclo
        {
            get { return ciclo; }
            set { ciclo = value; }
        }

        public int IdAluno
        {
            get { return idAluno; }
            set { idAluno = value; }
        }

        public void CriarConsulta()
        {

        }


        public void AlterarPront()
        {

        }


        public void VisualizarPront()
        {

        }

    }
}