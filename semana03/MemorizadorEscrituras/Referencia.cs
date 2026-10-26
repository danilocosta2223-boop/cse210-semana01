public class Referencia
{
    private string _livro;
    private int _capitulo;
    private int _versiculo;
    private int _versiculoFim;

    public Referencia(string livro, int capitulo, int versiculo)
    {
        _livro = livro;
        _capitulo = capitulo;
        _versiculo = versiculo;
        _versiculoFim = 0;
    }

    public Referencia(string livro, int capitulo, int versiculo, int versiculoFim)
    {
        _livro = livro;
        _capitulo = capitulo;
        _versiculo = versiculo;
        _versiculoFim = versiculoFim;
    }

    public string ObterTextoReferencia()
    {
        if (_versiculoFim == 0)
        {
            return $"{_livro} {_capitulo}:{_versiculo}";
        }

        return $"{_livro} {_capitulo}:{_versiculo}-{_versiculoFim}";
    }
}
