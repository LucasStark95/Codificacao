
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * 
 */
public class Anamnese {

    private int cod_pergunta;
    private string respostaPergunta;
    private string conclusao;

    public Anamnese() {
    }

    public int CodPergunta
    {
        get { return cod_pergunta; }
        set { cod_pergunta = value; }
    }

    public string RespostaPergunta
    {
        get { return respostaPergunta;}
        set { respostaPergunta = value; }
    }
    public string Conclusao {
        get { return conclusao; }
        set { conclusao = value; }
    }
}