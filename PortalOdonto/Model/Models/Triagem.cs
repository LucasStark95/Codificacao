
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * 
 */
public class Triagem
{


    private string dataTriagem;
    private string motivoConsulta;
    private string nomePaciente;
    private string procedimento;
    private bool radiologia;
    private bool periapical;
    private bool panoramica;
    private bool interproximal;
    private bool dentistica;
    private bool classeI;
    private bool classeII;
    private bool lasseIII;
    private bool classeIV;
    private bool classeV;
    private bool clareamento;
    private bool periodontia;
    private bool cirurgia;
    private bool cirugiaSimples;
    private bool cirugiaAvancada;
    private bool endodontia;
    private bool pediatria;
    private bool protese;
    private bool protesePt;
    private bool protesePpr;
    private bool proteseFixa;
    private int id;

    public Triagem()
    {
    }

    public int Id
    {
        get { return id; }
        set { id = value; }
    }
    public string DataTriagem
    {
        get { return dataTriagem; }
        set { dataTriagem = value; }
    }
    public string MotivoConsulta
    {
        get { return motivoConsulta; }
        set { motivoConsulta = value; }
    }
    public string NomePaciente
    {
        get { return nomePaciente; }
        set { nomePaciente = value; }
    }
    public string Procedimento
    {
        get { return procedimento; }
        set { procedimento = value; }
    }
    public bool Radiologia
    {
        get { return radiologia; }
        set { radiologia = value; }
    }
    public bool Periapical
    {
        get { return periapical; }
        set { periapical = value; }
    }
    public bool Panoramica
    {
        get { return panoramica; }
        set { panoramica = value; }
    }
    public bool Interproximal
    {
        get { return interproximal; }
        set { interproximal = value; }
    }
    public bool Dentistica
    {
        get { return dentistica; }
        set { dentistica = value; }
    }
    public bool ClasseI
    {
        get { return classeI; }
        set { classeI = value; }
    }
    public bool ClasseII
    {
        get { return classeII; }
        set { classeII = value; }
    }
    public bool LasseIII
    {
        get { return lasseIII; }
        set { lasseIII = value; }
    }
    public bool ClasseIV
    {
        get { return classeIV; }
        set { classeIV = value; }
    }
    public bool ClasseV
    {
        get { return classeV; }
        set { classeV = value; }
    }
    public bool Clareamento
    {
        get { return clareamento; }
        set { clareamento = value; }
    }
    public bool Periodontia
    {
        get { return periodontia; }
        set { periodontia = value; }
    }
    public bool Cirurgia
    {
        get { return cirurgia; }
        set { cirurgia = value; }
    }
    public bool CirugiaSimples
    {
        get { return cirugiaSimples; }
        set { cirugiaSimples = value; }
    }
    public bool CirugiaAvancada
    {
        get { return cirugiaAvancada; }
        set { cirugiaAvancada = value; }
    }
    public bool Endodontia
    {
        get { return endodontia; }
        set { endodontia = value; }
    }
    public bool Pediatria
    {
        get { return pediatria; }
        set { pediatria = value; }
    }
    public bool Protese
    {
        get { return protese; }
        set { protese = value; }
    }
    public bool ProtesePt
    {
        get { return protesePt; }
        set { protesePt = value; }
    }
    public bool ProtesePpr
    {
        get { return protesePpr; }
        set { protesePpr = value; }
    }
    public bool ProteseFixa
    {
        get { return proteseFixa; }
        set { proteseFixa = value; }
    }
}