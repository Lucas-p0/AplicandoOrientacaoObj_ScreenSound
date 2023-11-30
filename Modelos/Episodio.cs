namespace ScreenSound.Modelos;

internal class Episodio
{

    private List<string> convidados = new();
    public Episodio(string? nome, int ordem, int duracao)
    {
        Nome = nome;
        this.Ordem = ordem;
        Duracao = duracao;
    }

    public int Ordem { get; }
    public string? Nome { get; }
    public int Duracao { get; }
    public string? Resumo => $"Episodio {Ordem}: {Nome} | Duração:({Duracao}min) - {string.Join(", ", convidados)}";

    public void AdicionarConvidados(string convidado)
    {
        convidados.Add(convidado);
    }

}