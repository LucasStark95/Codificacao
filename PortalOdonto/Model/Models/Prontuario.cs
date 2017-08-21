
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Models
{
    public class Prontuario
    {

        private string data_alteracao;
        private string diagnostico;
        private string data_inicial;
        private string descricao;
        private int idProntuario;


        public Prontuario()
        {
        }

        public int IdProntuario
        {
            get { return idProntuario; }
            set { idProntuario = value; }
        }
        public string Data_alteracao
        {
            get { return data_alteracao; }
            set { data_alteracao = value; }
        }
        public string Diagnostico
        {
            get { return diagnostico; }
            set { diagnostico = value; }
        }
        public string Data_inicial
        {
            get { return data_inicial; }
            set { data_inicial = value; }
        }
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
    }
}