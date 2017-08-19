
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Usuario
{

    private string nomeUsuario;
    private int matriculaUsuario;
    private string emailUsuario;
    private string senhaUsuario;
    private string tipoUsuario;

    public Usuario()
    {
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

    public string TipoUsuario
    {
        get { return tipoUsuario; }
        set { tipoUsuario = value; }
    }
}