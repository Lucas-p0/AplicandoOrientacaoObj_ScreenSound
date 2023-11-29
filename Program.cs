
// //MUSICA
// Banda OficinaG3 = new Banda("Oficina G3");
// Album albumOficinaG3 = new Album("Histórias e Bicicletas");

// Musica musica1 = new Musica(OficinaG3, "De Olhos Fechados")
// {
//     Duracao = 132,
//     Disponivel = true

// };

// Musica musica2 = new Musica(OficinaG3, "Lágrimas")
// {
//     Duracao = 322,
//     Disponivel = false
// };


// OficinaG3.AdicionarAlbum(albumOficinaG3);
// OficinaG3.ExibirDiscografia();

// musica1.ExibirFichaTecnica();
// musica2.ExibirFichaTecnica();
// albumOficinaG3.AdicionarMusica(musica1);
// albumOficinaG3.AdicionarMusica(musica2);
// albumOficinaG3.ExibirMusicasDoAlbum();

// PODCAST

Episodio episodio2 = new Episodio("O que é Inteligência Artificial?", 2, 24);
episodio2.AdicionarConvidados("Fernando");
episodio2.AdicionarConvidados("Catarina");

Episodio episodio1 = new Episodio("A verdade está lá fora", 1, 34);
episodio1.AdicionarConvidados("Fernando");
episodio1.AdicionarConvidados("Catarina");
episodio1.AdicionarConvidados("VOvó juju");

Episodio episodio3 = new Episodio("Os perigos da IA", 3, 43);
episodio3.AdicionarConvidados("VOvó juju");
episodio3.AdicionarConvidados("Opa");

Episodio episodio5 = new Episodio("Guerra", 5, 33);
episodio5.AdicionarConvidados("Catarina");

Episodio episodio4 = new Episodio("O futuro da IA", 4, 23);
episodio4.AdicionarConvidados("Opa");
episodio4.AdicionarConvidados("Nicoliles");






Podcast InteligenciaLTDA = new Podcast("Inteligencia LTDA", "Vilela");
InteligenciaLTDA.AdicionaEpisodios(episodio1);
InteligenciaLTDA.AdicionaEpisodios(episodio2);
InteligenciaLTDA.AdicionaEpisodios(episodio3);
InteligenciaLTDA.AdicionaEpisodios(episodio4);
InteligenciaLTDA.AdicionaEpisodios(episodio5);


InteligenciaLTDA.ExibeDetalhesPodcast();
//InteligenciaLTDA.ExibeDetalhesPodcast();
// podcast2.ExibeDetalhesPodcast();
