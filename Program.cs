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

Dictionary<string, Banda> bandasRegistrasdas = new();
bandasRegistrasdas.Add(ira.Nome, ira);
bandasRegistrasdas.Add(oficinaG3.Nome, oficinaG3);

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
    Console.WriteLine($"Digite 3 para avaliar uma banda");
    Console.WriteLine($"Digite 4 para mostrar todas as bandas");
    Console.WriteLine($"Digite 5 para exibir a média de uma banda");
    Console.WriteLine($"Digite 0 para sair");

    Console.Write($"\nDigite a sua opção:");
    string opcaoEcolhida = Console.ReadLine()!;
    int opcaoEcolhidaNumerica = int.Parse(opcaoEcolhida);
    switch (opcaoEcolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            RegristarAlbum();
            break;
        case 3:
            AvaliarUmaBanda();
            break;
        case 4:
            MostarBandasRegistradas();
            break;
        case 5:
            MenuExibirDetalhes menu = new();
            menu.Executar(bandasRegistrasdas);
            ExibirOpcoesDoMenu();
            break;
        case 0:
            Console.WriteLine($"Acabou!!!");
            break;
        default:
            Console.WriteLine("Opção invalida!");
            break;
    };
};
void RegistrarBanda()
{
    Console.Clear();
    ExibindoTituloDaOpcao("Registro de bandas");
    Console.Write($"Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    Banda banda = new Banda(nomeDaBanda);
    bandasRegistrasdas.Add(nomeDaBanda, banda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(4000);
    Console.Clear();
    ExibirOpcoesDoMenu();
    ExibirOpcoesDoMenu();
};
void MostarBandasRegistradas()
{
    Console.Clear();
    ExibindoTituloDaOpcao("Exibindo bandas registradas:");

    foreach (string banda in bandasRegistrasdas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    };
    Console.WriteLine($"\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    mensagemDeBoasVindas();
    ExibirOpcoesDoMenu();

}
void ExibindoTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
};
void RegristarAlbum()
{
    Console.Clear();
    ExibindoTituloDaOpcao("Registro de álbum");
    Console.Write
    ("Digite a banda cujo o álbum deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistrasdas.ContainsKey(nomeDaBanda))
    {
        Console.Write("Agora digite o titulo do álbum: ");
        string tituloAlbum = Console.ReadLine()!;
        Banda banda = bandasRegistrasdas[nomeDaBanda];
        Console.WriteLine($"O álgum {tituloAlbum} da banda {nomeDaBanda} foi registrado!");
        Thread.Sleep(2500);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine($"\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }


}

mensagemDeBoasVindas();
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
