using ScreenSound_APIExterna.Modelos;

namespace ScreenSound_APIExterna.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistaPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine($"Artistas do gênero {genero}:");
        foreach (var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }


    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
    {
        var musicasDoArtista = musicas.Where(musicas => musicas.Artista!.Equals(nomeDoArtista)).ToList();
        Console.WriteLine($"Músicas do artista {nomeDoArtista}:");
        foreach (var musica in musicasDoArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }

    public static void FiltrarMusicasPorTonalidade(List<Musica> musicas)
    {
        var musicasPorTonalidade = musicas.Where(musica => musica.Tonalidade.Equals("C#")).ToList();
        Console.WriteLine($"Músicas na tonalidade C#:");
        foreach (var musica in musicasPorTonalidade)
        {
            Console.WriteLine($"- {musica.Nome} ({musica.Artista})");
        }
    }
}
