namespace ScreenSound.Modelos;

internal class Podcast
{
    private List<Episodio> episodios = new();
    public Podcast(string nome, string? host)
    {
        Nome = nome;
        Host = host;

    }
    public int TotalEpisodios => episodios.Count;
    public string Nome { get; }
    public string? Host { get; }

    public void ExibeDetalhesPodcast()
    {
        Console.WriteLine($"\nOlá você está no {Nome} eu sou o {Host} e nós temos o total de {TotalEpisodios} episodios\n\n");

        foreach (Episodio episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }
    }
    public void AdicionaEpisodios(Episodio episodio)
    {
        episodios.Add(episodio);
    }
    // public void ExibeEpisodios()
    // {
    //     Console.WriteLine($"Lista de episodios do podcast: {Nome}");
    //     foreach (var episodio in episodios)
    //     {
    //         Console.WriteLine($"Episodio: {episodio.Nome} ");

    //     }
    // }
}