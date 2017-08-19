
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * 
 */
public class Consulta_M {

    private string dataConsulta;
    private string nomeAluno;
    private string nomePaciente;
    private int id;


    public Consulta_M() {
    }

    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public string DataConsulta
    {
        get { return dataConsulta; }
        set { dataConsulta = value; }
    }


    public string NomeAluno
    {
        get { return nomeAluno; }
        set { nomeAluno = value; }
    }


    public string NomePaciente
    {
        get { return nomePaciente; }
        set { nomePaciente = value; }
    }




}