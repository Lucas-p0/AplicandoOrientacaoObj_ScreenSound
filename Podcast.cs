class Podcast
{
    private List<Episodio> episodios = new List<Episodio>();
    public Podcast(string nome, string? host)
    {
        Nome = nome;
        Host = host;

    }
    public int TotalEpisodios => episodios.Count();
    public string Nome { get; }
    public string? Host { get; }
    public Episodio? Episodio { get; set; }
    public Convidado? Convidado { get; set; }
    public void ExibeDetalhesPodcast()
    {
        Console.WriteLine($"Olá você está no {Nome} eu sou o {Host} e nós temos o total de {TotalEpisodios} episodios");
    }
    public void AdicionaEpisodios(Episodio episodio)
    {
        episodios.Add(episodio);
    }
    public void ExibeEpisodios()
    {
        Console.WriteLine($"Lista de episodios do podcast: {Nome}");
        foreach (var episodio in episodios)
        {
            Console.WriteLine($"Episodio: {episodio.Nome}");

        }
    }
}