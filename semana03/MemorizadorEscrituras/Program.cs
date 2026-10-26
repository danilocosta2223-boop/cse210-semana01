using System;

class Program
{
    static void Main(string[] args)
    {
        Referencia referencia = new Referencia("João", 3, 16);

        Escritura escritura = new Escritura(
            referencia,
            "Porque Deus amou o mundo de tal maneira que deu o seu Filho unigênito para que todo aquele que nele crê não pereça mas tenha a vida eterna"
        );

        while (!escritura.TodasOcultas())
        {
            Console.Clear();

            Console.WriteLine(escritura.ObterTextoExibicao());

            Console.WriteLine();
            Console.Write("Pressione Enter ou digite sair: ");

            string resposta = Console.ReadLine();

            if (resposta.ToLower() == "sair")
            {
                break;
            }

            escritura.OcultarPalavrasAleatorias(3);
        }

        Console.Clear();
        Console.WriteLine("Programa encerrado.");
    }
}
