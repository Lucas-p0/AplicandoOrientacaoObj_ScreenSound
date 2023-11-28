class Convidado
{
    public Convidado(string? name, string? especializacao)
    {
        Name = name;
        Especializacao = especializacao;
    }

    public string? Name { get; set; }
    public string? Especializacao { get; set; }
    public string? descricao { get; set; }
    public int idade { get; set; }

}