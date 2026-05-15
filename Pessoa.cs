using System;

namespace Mediator;

public class Pessoa 
{
    private IMediador _mediador;
    public string Nome;

    public Pessoa(IMediador m, string nome) 
    {
        _mediador = m;
        Nome = nome;
    }

    public void Mandar(string msg) 
    {
        Console.WriteLine($"\n[{Nome} enviou]: {msg}");
        _mediador.Enviar(msg, this);
    }

    public void Receber(string msg, string deQuem) 
    {
        Console.WriteLine($" -> {Nome} leu a mensagem de {deQuem}");
    }
}
