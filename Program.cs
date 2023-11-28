//MUSICA
Banda OficinaG3 = new Banda("Oficina G3");
Album albumOficinaG3 = new Album("Histórias e Bicicletas");

Musica musica1 = new Musica(OficinaG3, "De Olhos Fechados")
{
    Duracao = 234,
    Disponivel = true
};
Musica musica2 = new Musica(OficinaG3, "Lágrimas")
{
    Duracao = 322,
    Disponivel = false
};


OficinaG3.AdicionarAlbum(albumOficinaG3);
OficinaG3.ExibirDiscografia();

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumOficinaG3.AdicionarMusica(musica1);
albumOficinaG3.AdicionarMusica(musica2);
albumOficinaG3.ExibirMusicasDoAlbum();

// PODCAST
Episodio episodio1 = new Episodio("A verdade está lá fora", 1)
{
    Resumo = "Aliens existem",
    Duracao = 234
};
Episodio episodio2 = new Episodio("O que é Inteligência Artificial?", 2)
{
    Resumo = "Vão dominar o mundo?",
    Duracao = 234
};
Episodio episodio3 = new Episodio("Os perigos da IA", 3)
{
    Resumo = "Matrix da vida real",
    Duracao = 234
};
Episodio episodio4 = new Episodio("O futuro da IA", 4)
{
    Resumo = "Grandes guerras inteligentes",
    Duracao = 234
};
Episodio episodio5 = new Episodio("Guerra", 5)
{
    Resumo = "Histódias das grandes guerras",
    Duracao = 234
};


Podcast InteligenciaLTDA = new Podcast("Inteligencia LTDA", "Vilela")
{
};

InteligenciaLTDA.AdicionaEpisodios(episodio1);
InteligenciaLTDA.AdicionaEpisodios(episodio2);
InteligenciaLTDA.AdicionaEpisodios(episodio3);
InteligenciaLTDA.AdicionaEpisodios(episodio4);
InteligenciaLTDA.AdicionaEpisodios(episodio5);
InteligenciaLTDA.ExibeEpisodios();
InteligenciaLTDA.ExibeDetalhesPodcast();
// podcast2.ExibeDetalhesPodcast();
