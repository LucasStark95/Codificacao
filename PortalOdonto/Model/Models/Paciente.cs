
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * 
 */
public class Paciente {

    private string nomePaciente;
    private string enderecoPaciente;
    private string cpfPaciente;
    private string rgPaciente;
    private string responsavelPaciente;
    private string dt_nascimentoPaciente;
    private char sexo;
    private string naturalidade;
    private string estado;
    private string nacionalidade;
    private string estadoCivil;
    private string raca;
    private string religiao;
    private double peso;
    private double altura;
    private string grauDeInstrucao;
    private string pai;
    private string mae;
    private string nacionalidadePai;
    private string nacionalidadeMae;
    private string profissao;
    private string zona;
    private string contato;
    private string cidade;
    private double pressaoArterial;
    private double batimentoCardiaco;
    private int id;

    public Paciente() {
    }

    public int Id
    {
        get { return id; }
        set { id = value}
    }
    public string NomePaciente {
        get { return nomePaciente; }
        set { nomePaciente = value; }
    }
    public string EnderecoPaciente
    {
        get { return enderecoPaciente; }
        set { enderecoPaciente = value; }
    }
    public string CpfPaciente {
        get { return cpfPaciente; }
        set { cpfPaciente = value; }
    }

    public string RgPaciente
    {
        get
        { return rgPaciente; }
        set { rgPaciente = value; }
    }

    public string ResponsavelPaciente
    {
        get { return responsavelPaciente; }
        set { responsavelPaciente = value; }
    }

    public string Dt_nascimentoPaciente
    {
        get { return dt_nascimentoPaciente; }
        set { dt_nascimentoPaciente = value; }
    }

    public char Sexo
    {
        get { return sexo; }
        set { sexo = value; }
    }

    public string Naturalidade
    {
        get { return naturalidade; }
        set { naturalidade = value; }
    }

    public string Estado
    {
        get { return estado; }
        set { estado = value; }
    }

    public string Nacionalidade
    {
        get { return nacionalidade; }
        set { nacionalidade = value; }
    }

    public string EstadoCivil
    {
        get { return estadoCivil; }
        set { estadoCivil = value; }
    }

    public string Raca
    {
        get { return raca; }
        set { raca = value; }
    }

    public string Religiao
    {
        get { return religiao; }
        set { religiao = value; }
    }

    public double Peso {
        get { return peso; }
        set { peso = value; }
    }

    public double Altura
    {
        get { return altura; }
        set { altura = value; }
    }

    public string GrauDeInstrucao
    {
        get { return grauDeInstrucao; }
        set { grauDeInstrucao = value; }
    }

    public string Pai {
        get { return pai; }
        set { pai = value; }
    }

    public string Mae
    {
        get { return mae; }
        set { mae = value; }
    }

    public string NacionalidadePai
    {
        get { return nacionalidadePai; }
        set { nacionalidadePai = value; }
    }

    public string NacionalidadeMae
    {
        get { return nacionalidadeMae; }
        set { nacionalidadeMae = value; }
    }

    public string Profissao
    {
        get { return profissao; }
        set { profissao = value; }
    }

    public string Zona {
        get { return zona;  }
        set { zona = value; }
    }

    public string Contato
    {
        get { return contato; }
        set { contato = value; }
    }

    public string Cidade
    {
        get { return cidade; }
        set { cidade = value; }
    }

    public double PressaoArterial
    {
        get { return pressaoArterial; }
        set { pressaoArterial = value; }
    }

    public double BatimentoCardiaco
    {
        get { return batimentoCardiaco; }
        set { batimentoCardiaco = value; }
    }
}