using AplicandoOrientacaoObj_ScreenSound.Modelos;

namespace ScreenSound.Modelos;

internal class Album : IAvaliavel
{
    public Album(string nome)
    {
        Nome = nome;
    }
    private List<Musica> musicas = new List<Musica>();
    private List<Avaliacao> notas = new();
    public string Nome { get; set; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public double Media
    {
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(a => a.Nota);
        }
    }

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }
    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum: {Nome}\n");


        foreach (var musica in musicas)
        {
            Console.WriteLine($"Musica: {musica.Nome}");
        }
        System.Console.WriteLine($"Para ouvir esse álbum inteiro você precisa de {DuracaoTotal} segundos");
    }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }

    public static implicit operator Album(Banda v)
    {
        throw new NotImplementedException();
    }
}