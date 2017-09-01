
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Models
{
    public class Prontuario
    {

        private string dataAlteracao;
        private string diagnostico;
        private string dataInicial;
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
        public string DataAlteracao
        {
            get { return dataAlteracao; }
            set { dataAlteracao = value; }
        }
        public string Diagnostico
        {
            get { return diagnostico; }
            set { diagnostico = value; }
        }
        public string DataInicial
        {
            get { return dataInicial; }
            set { dataInicial = value; }
        }
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
    }
}