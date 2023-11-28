class Episodio
{

    private List<Convidado> convidados = new List<Convidado>();
    public Episodio(string? nome, int ordem)
    {
        Nome = nome;
        this.ordem = ordem;
    }

    public string? Nome { get; }
    public int ordem { get; }
    public string? Resumo { get; set; }
    public int Duracao { get; set; }

    public void AdicionaConvidado(Convidado convidado)
    {
        convidados.Add(convidado);
    }

}