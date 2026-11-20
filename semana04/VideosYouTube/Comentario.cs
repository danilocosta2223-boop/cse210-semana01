public class Comentario
{
    private string _nomePessoa;
    private string _textoComentario;

    public Comentario(string nomePessoa, string textoComentario)
    {
        _nomePessoa = nomePessoa;
        _textoComentario = textoComentario;
    }

    public string ObterNomePessoa()
    {
        return _nomePessoa;
    }

    public string ObterTextoComentario()
    {
        return _textoComentario;
    }
}
