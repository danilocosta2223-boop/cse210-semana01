using System.Collections.Generic;
using System.Text;

public class Pedido
{
    private List<Produto> _produtos;
    private Cliente _cliente;

    public Pedido(Cliente cliente)
    {
        _cliente = cliente;
        _produtos = new List<Produto>();
    }

    public void AdicionarProduto(Produto produto)
    {
        _produtos.Add(produto);
    }

    public double CalcularTotal()
    {
        double total = 0;

        foreach (Produto produto in _produtos)
        {
            total += produto.CalcularCustoTotal();
        }

        total += _cliente.MoraNosEUA() ? 5 : 35;

        return total;
    }

    public string ObterEtiquetaEmbalagem()
    {
        StringBuilder sb = new StringBuilder();

        foreach (Produto produto in _produtos)
        {
            sb.AppendLine(produto.ObterEtiqueta());
        }

        return sb.ToString();
    }

    public string ObterEtiquetaEnvio()
    {
        return $"{_cliente.ObterNome()}\n{_cliente.ObterEndereco().ObterEnderecoCompleto()}";
    }
}
