using System.Collections.Generic;

namespace MediatorSimples;

public class GrupoTrabalho : IMediador 
{
    private List<Pessoa> _pessoas = new();

    public void Adicionar(Pessoa p) => _pessoas.Add(p);

    public void Enviar(string msg, Pessoa remetente) 
    {
        foreach (var p in _pessoas) 
        {
            if (p != remetente) 
            {
                p.Receber(msg, remetente.Nome);
            }
        }
    }
}
