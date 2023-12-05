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
    { 5, new MenuAvaliarAlbum() },
    { 6, new MenuExibirDetalhes() },
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
    Console.WriteLine($"Digite 5 para avaliar um álbum");
    Console.WriteLine($"Digite 6 para exibir detalhes de uma banda");
    Console.WriteLine($"Digite 0 para sair");

    Console.Write($"\nDigite a sua opção:");
    string opcaoEcolhida = Console.ReadLine()!;
    int opcaoEcolhidaNumerica = int.Parse(opcaoEcolhida);
    if (opcoes.ContainsKey(opcaoEcolhidaNumerica))
    {
        Menu menuASerExibido = opcoes[opcaoEcolhidaNumerica];
        menuASerExibido.Executar(bandasRegistradas);
        if (opcaoEcolhidaNumerica > 0) ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine("Opção invalida!");
    }
};
// ExibirOpcoesDoMenu();