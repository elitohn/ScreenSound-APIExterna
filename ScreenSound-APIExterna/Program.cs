using ScreenSound_APIExterna.Modelos;
using System.Text.Json;
using ScreenSound_APIExterna.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        //musicas[0].ExibirDetalhesDaMusica();

        LinqFilter.FiltrarMusicasPorTonalidade(musicas);

        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistaPorGeneroMusical(musicas, "pop");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Michael Jackson");

        //var musicasPreferidasDoWell = new MusicasPreferidas("Well");
        //musicasPreferidasDoWell.AdicionarMusicaFavorita(musicas[1]);
        //musicasPreferidasDoWell.AdicionarMusicaFavorita(musicas[377]);
        //musicasPreferidasDoWell.AdicionarMusicaFavorita(musicas[4]);
        //musicasPreferidasDoWell.AdicionarMusicaFavorita(musicas[6]);
        //musicasPreferidasDoWell.AdicionarMusicaFavorita(musicas[1467]);

        //musicasPreferidasDoWell.ExibirMusicasFavoritas();

        //var musicasPreferidasDoJorge = new MusicasPreferidas("Jorge");
        //musicasPreferidasDoJorge.AdicionarMusicaFavorita(musicas[500]);
        //musicasPreferidasDoJorge.AdicionarMusicaFavorita(musicas[637]);
        //musicasPreferidasDoJorge.AdicionarMusicaFavorita(musicas[428]);
        //musicasPreferidasDoJorge.AdicionarMusicaFavorita(musicas[13]);
        //musicasPreferidasDoJorge.AdicionarMusicaFavorita(musicas[71]);

        //musicasPreferidasDoJorge.ExibirMusicasFavoritas();

        //musicasPreferidasDoJorge.GerarArquivoJson();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}