namespace AplicandoOrientacaoObj_ScreenSound.Menus;
namespace AplicandoOrientacaoObj_ScreenSound.Modelos;

internal class MenuAvaliarBanda
{
    public void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        //Digite a banda que deseja avaliar
        //Se a banda exstir nodicionario >> atribuir uma nota
        //Senão, voltar ao menu principal
        Console.Clear();
        ExibindoTituloDaOpcao("Avaliar Banda");
        Console.Write("Digite o nome que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistrasdas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistrasdas[nomeDaBanda];
            Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
            Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
            banda.AdicionarNota(nota);
            Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para a banda {nomeDaBanda}");
            Thread.Sleep(2000);
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine($"\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        };
    }
}
