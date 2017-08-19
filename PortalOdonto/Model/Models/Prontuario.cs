
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * 
 */
public class Prontuario
{

    private string data_alteracao;
    private string diagnostico;
    private string data_inicial;
    private string descricao;
    private int id;

    
    public Prontuario()
    {
    }

    public int Id
    {
        get { return id; }
        set { id = value; }
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