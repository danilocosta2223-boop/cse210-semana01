using System;
using System.Collections.Generic;

public class Escritura
{
    private Referencia _referencia;
    private List<Palavra> _palavras;

    public Escritura(Referencia referencia, string texto)
    {
        _referencia = referencia;
        _palavras = new List<Palavra>();

        string[] palavras = texto.Split(' ');

        foreach (string palavra in palavras)
        {
            _palavras.Add(new Palavra(palavra));
        }
    }

    public void OcultarPalavrasAleatorias(int quantidade)
    {
        Random random = new Random();

        for (int i = 0; i < quantidade; i++)
        {
            int indice = random.Next(_palavras.Count);

            if (!_palavras[indice].EstaOculta())
            {
                _palavras[indice].Ocultar();
            }
        }
    }

    public bool TodasOcultas()
    {
        foreach (Palavra palavra in _palavras)
        {
            if (!palavra.EstaOculta())
            {
                return false;
            }
        }

        return true;
    }

    public string ObterTextoExibicao()
    {
        string texto = _referencia.ObterTextoReferencia() + "\n\n";

        foreach (Palavra palavra in _palavras)
        {
            texto += palavra.ObterTextoExibicao() + " ";
        }

        return texto;
    }
}
