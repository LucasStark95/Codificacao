
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Model.Models
{
    public class Usuario
    {

        private int idUsuario;
        private string nomeUsuario;
        private int matriculaUsuario;
        private string emailUsuario;
        private string senhaUsuario;
        private string nomeMae;
        private int tipoUsuario;
        private string endereco;

        public Usuario()
        {
        }

        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        public string NomeMae
        {
            get { return nomeMae; }
            set { nomeMae = value; }
        }
        
        public string NomeUsuario
        {
            get { return nomeUsuario; }
            set { nomeUsuario = value; }
        }

        public int MatriculaUsuario
        {
            get { return matriculaUsuario; }
            set { matriculaUsuario = value; }
        }

        public string EmailUsuario
        {
            get { return emailUsuario; }
            set { emailUsuario = value; }
        }

        public string SenhaUsuario
        {
            get { return senhaUsuario; }
            set { senhaUsuario = value; }
        }

        public int TipoUsuario
        {
            get { return tipoUsuario; }
            set { tipoUsuario = value; }
        }
    }
}