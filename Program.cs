using AplicandoOrientacaoObj_ScreenSound.Menus;
using AplicandoOrientacaoObj_ScreenSound.Modelos;
using ScreenSound.Modelos;



Banda ira = new("Ira!");
ira.AdicionarNota(new Avaliacao(10));
ira.AdicionarNota(new Avaliacao(8));
ira.AdicionarNota(new Avaliacao(3));

Banda oficinaG3 = new("Oficina G3");
oficinaG3.AdicionarNota(new Avaliacao(10));
oficinaG3.AdicionarNota(new Avaliacao(7));

Dictionary<string, Banda> bandasRegistradas = new();
bandasRegistradas.Add(ira.Nome, ira);
bandasRegistradas.Add(oficinaG3.Nome, oficinaG3);

Dictionary<int, Menu> opcoes = new()
{
    { 1, new MenuRegistrarBanda() },
    { 2, new MenuRegristarAlbum() },
    { 3, new MenuMostarBandasRegistrada() },
    { 4, new MenuAvaliarBanda() },
    { 5, new MenuExibirDetalhes() },
    { 0, new MenuSair() }
};

void mensagemDeBoasVindas()
{
    Console.Clear();
    string mensagem = @"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░";
    Console.WriteLine(mensagem);

};
void ExibirOpcoesDoMenu()
{
    Console.Clear();
    mensagemDeBoasVindas();
    Console.WriteLine($"\nBoas vindas ao Screen Sound");
    Console.WriteLine($"\nDigite 1 para registrar uma banda");
    Console.WriteLine($"Digite 2 para registrar o álbum de uma banda");
    Console.WriteLine($"Digite 3 para mostrar todas as bandas");
    Console.WriteLine($"Digite 4 para avaliar uma banda");
    Console.WriteLine($"Digite 5 para exibir detalhes de uma banda");
    Console.WriteLine($"Digite 0 para sair");

    Console.Write($"\nDigite a sua opção:");
    string opcaoEcolhida = Console.ReadLine()!;
    int opcaoEcolhidaNumerica = int.Parse(opcaoEcolhida);
    if (opcoes.ContainsKey(opcaoEcolhidaNumerica))
    {
        Menu menuASerExibido = opcoes[opcaoEcolhidaNumerica];
        menuASerExibido.Executar(bandasRegistradas);
    }
    else
    {
        Console.WriteLine("Opção invalida!");
    }

    switch (opcaoEcolhidaNumerica)
    {
        case 1:
            MenuRegistrarBanda menu1 = new();
            menu1.Executar(bandasRegistradas);
            ExibirOpcoesDoMenu();
            break;
        case 2:
            MenuRegristarAlbum menu2 = new();
            menu2.Executar(bandasRegistradas);
            ExibirOpcoesDoMenu();
            break;
        case 3:
            MenuMostarBandasRegistrada menu3 = new();
            menu3.Executar(bandasRegistradas);
            ExibirOpcoesDoMenu();
            break;
        case 4:
            MenuAvaliarBanda menu4 = new();
            menu4.Executar(bandasRegistradas);
            ExibirOpcoesDoMenu();
            break;
        case 5:
            MenuExibirDetalhes menu5 = new();
            menu5.Executar(bandasRegistradas);
            ExibirOpcoesDoMenu();
            break;
        case 0:
            MenuSair menu0 = new();
            menu0.Executar(bandasRegistradas);
            ExibirOpcoesDoMenu();
            break;
        default:

            break;
    };
};
ExibirOpcoesDoMenu();












// // //MUSICA
// // Banda OficinaG3 = new Banda("Oficina G3");
// // Album albumOficinaG3 = new Album("Histórias e Bicicletas");

// // Musica musica1 = new Musica(OficinaG3, "De Olhos Fechados")
// // {
// //     Duracao = 132,
// //     Disponivel = true

// // };

// // Musica musica2 = new Musica(OficinaG3, "Lágrimas")
// // {
// //     Duracao = 322,
// //     Disponivel = false
// // };


// // OficinaG3.AdicionarAlbum(albumOficinaG3);
// // OficinaG3.ExibirDiscografia();

// // musica1.ExibirFichaTecnica();
// // musica2.ExibirFichaTecnica();
// // albumOficinaG3.AdicionarMusica(musica1);
// // albumOficinaG3.AdicionarMusica(musica2);
// // albumOficinaG3.ExibirMusicasDoAlbum();

// // PODCAST



// Episodio episodio2 = new Episodio("O que é Inteligência Artificial?", 2, 24);
// episodio2.AdicionarConvidados("Fernando");
// episodio2.AdicionarConvidados("Catarina");

// Episodio episodio1 = new Episodio("A verdade está lá fora", 1, 34);
// episodio1.AdicionarConvidados("Fernando");
// episodio1.AdicionarConvidados("Catarina");
// episodio1.AdicionarConvidados("VOvó juju");

// Episodio episodio3 = new Episodio("Os perigos da IA", 3, 43);
// episodio3.AdicionarConvidados("VOvó juju");
// episodio3.AdicionarConvidados("Opa");

// Episodio episodio5 = new Episodio("Guerra", 5, 33);
// episodio5.AdicionarConvidados("Catarina");

// Episodio episodio4 = new Episodio("O futuro da IA", 4, 23);
// episodio4.AdicionarConvidados("Opa");
// episodio4.AdicionarConvidados("Nicoliles");

// Podcast InteligenciaLTDA = new Podcast("Inteligencia LTDA", "Vilela");
// InteligenciaLTDA.AdicionaEpisodios(episodio1);
// InteligenciaLTDA.AdicionaEpisodios(episodio2);
// InteligenciaLTDA.AdicionaEpisodios(episodio3);
// InteligenciaLTDA.AdicionaEpisodios(episodio4);
// InteligenciaLTDA.AdicionaEpisodios(episodio5);


// InteligenciaLTDA.ExibeDetalhesPodcast();
// //InteligenciaLTDA.ExibeDetalhesPodcast();
// // podcast2.ExibeDetalhesPodcast();
