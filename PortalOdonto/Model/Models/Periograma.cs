
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Periograma {

    private int numeroDente;
    private string diagnostico;
    private string proagnostico;
    private string dataInicial;
    private string dataReavaliacao;
    private int faceDistal;
    private int faceMesial;
    private string faceVestibular;
    private string faceLingual;
    private string facePalatina;
    private int faceMedialDistal;
    private int mobilidade;
    private string bifurcacao;
    private double indiceSagramento;
    private double indiceBioFilme;
    private int id;

    
    public Periograma()
    {
    }

    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public int NumeroDente {
        get { return numeroDente; }
        set { numeroDente = value; }
    }

    public string Diagnostico {
        get { return diagnostico; }
        set { diagnostico = value; }
    }
    public string Proagnostico {
        get { return proagnostico; }
        set { proagnostico = value; }
    }
    public string DataInicial {
        get { return dataInicial; }
        set { dataInicial = value; }
    }
    public string DataReavaliacao {
        get { return dataReavaliacao; }
        set { dataReavaliacao = value; }
    }
    public int FaceDistal { get
        { return faceDistal; }
        set { faceDistal = value; }
    }
    public int FaceMesial {
        get { return faceMesial; }
        set { faceMesial = value; }
    }
    public string FaceVestibular {
        get { return faceVestibular; }
        set { faceVestibular = value; }
    }
    public string FaceLingual {
        get { return faceLingual; }
        set { faceLingual = value; }
    }
    public string FacePalatina {
        get { return facePalatina; }
        set { facePalatina = value; }
    }
    public int FaceMedialDistal {
        get { return faceMedialDistal; }
        set { faceMedialDistal = value; }
    }
    public int Mobilidade {
        get { return mobilidade; }
        set { mobilidade = value; }
    }
    public string Bifurcacao {
        get { return bifurcacao; }
        set { bifurcacao = value; }
    }
    public double IndiceSagramento {
        get { return indiceSagramento; }
        set { indiceSagramento = value; }
    }
    public double IndiceBioFilme {
        get { return indiceBioFilme; }
        set { indiceBioFilme = value; }
    }
    public void CalcularSangramento() {
        
    }

    public void CalcularBiofilme() {
        
    }

}