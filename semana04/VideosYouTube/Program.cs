using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video(
            "Aprendendo C#",
            "João",
            600
        );

        video1.AdicionarComentario(
            new Comentario("Ana", "Muito bom!")
        );

        video1.AdicionarComentario(
            new Comentario("Pedro", "Excelente aula.")
        );

        video1.AdicionarComentario(
            new Comentario("Carlos", "Aprendi bastante.")
        );

        Video video2 = new Video(
            "Introdução ao GitHub",
            "Maria",
            450
        );

        video2.AdicionarComentario(
            new Comentario("Lucas", "Muito útil.")
        );

        video2.AdicionarComentario(
            new Comentario("Fernanda", "Gostei muito.")
        );

        video2.AdicionarComentario(
            new Comentario("Roberto", "Ótima explicação.")
        );

        Video video3 = new Video(
            "Programação Orientada a Objetos",
            "Daniel",
            720
        );

        video3.AdicionarComentario(
            new Comentario("Juliana", "Excelente conteúdo.")
        );

        video3.AdicionarComentario(
            new Comentario("Marcos", "Muito bem explicado.")
        );

        video3.AdicionarComentario(
            new Comentario("Patricia", "Me ajudou bastante.")
        );

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine("--------------------------------");

            Console.WriteLine($"Título: {video.ObterTitulo()}");
            Console.WriteLine($"Autor: {video.ObterAutor()}");
            Console.WriteLine($"Duração: {video.ObterDuracao()} segundos");

            Console.WriteLine(
                $"Número de comentários: {video.ObterNumeroComentarios()}"
            );

            Console.WriteLine();

            foreach (Comentario comentario in video.ObterComentarios())
            {
                Console.WriteLine(
                    $"{comentario.ObterNomePessoa()}: {comentario.ObterTextoComentario()}"
                );
            }

            Console.WriteLine();
        }
    }
}
