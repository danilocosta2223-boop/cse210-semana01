using System;

class Program
{
    static void Main(string[] args)
    {
        Endereco endereco1 = new Endereco(
            "Rua Principal 123",
            "Nova York",
            "NY",
            "USA"
        );

        Cliente cliente1 = new Cliente(
            "João Silva",
            endereco1
        );

        Pedido pedido1 = new Pedido(cliente1);

        pedido1.AdicionarProduto(
            new Produto("Notebook", "P001", 3500, 1)
        );

        pedido1.AdicionarProduto(
            new Produto("Mouse", "P002", 100, 2)
        );

        Endereco endereco2 = new Endereco(
            "Av Paulista 500",
            "São Paulo",
            "SP",
            "Brasil"
        );

        Cliente cliente2 = new Cliente(
            "Maria Souza",
            endereco2
        );

        Pedido pedido2 = new Pedido(cliente2);

        pedido2.AdicionarProduto(
            new Produto("Monitor", "P003", 1200, 1)
        );

        pedido2.AdicionarProduto(
            new Produto("Teclado", "P004", 200, 1)
        );

        Console.WriteLine("=== PEDIDO 1 ===");

        Console.WriteLine("Etiqueta de Embalagem:");
        Console.WriteLine(pedido1.ObterEtiquetaEmbalagem());

        Console.WriteLine("Etiqueta de Envio:");
        Console.WriteLine(pedido1.ObterEtiquetaEnvio());

        Console.WriteLine($"Total: ${pedido1.CalcularTotal()}");

        Console.WriteLine();

        Console.WriteLine("=== PEDIDO 2 ===");

        Console.WriteLine("Etiqueta de Embalagem:");
        Console.WriteLine(pedido2.ObterEtiquetaEmbalagem());

        Console.WriteLine("Etiqueta de Envio:");
        Console.WriteLine(pedido2.ObterEtiquetaEnvio());

        Console.WriteLine($"Total: ${pedido2.CalcularTotal()}");
    }
}
