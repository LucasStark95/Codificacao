
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Models
{
    public class Anamnese
    {

        private int cod_pergunta;
        private string respostaPergunta;
        private string conclusao;
        private int idAnamnese;

        public Anamnese()
        {
        }

        public int IdAnamnese
        {
            get { return idAnamnese; }
            set { idAnamnese = value; }
        }
        public int CodPergunta
        {
            get { return cod_pergunta; }
            set { cod_pergunta = value; }
        }

        public string RespostaPergunta
        {
            get { return respostaPergunta; }
            set { respostaPergunta = value; }
        }
        public string Conclusao
        {
            get { return conclusao; }
            set { conclusao = value; }
        }
    }
}