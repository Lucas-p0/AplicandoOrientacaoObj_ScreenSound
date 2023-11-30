using ScreenSound.Modelos;


namespace AplicandoOrientacaoObj_ScreenSound.Menus;

internal class MenuExibirDetalhes
{
    void ExibindoTituloDaOpcao(string titulo)
    {
        int quantidadeDeLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos + "\n");
    }
    public void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.Clear();
        ExibindoTituloDaOpcao("Exibir detalhe da banda");
        Console.WriteLine("Digite o nome da banda que deseja conhecer melhor: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.WriteLine($"\nA média da banda: {nomeDaBanda} é {banda.Media}");

            //Espaço para Função

            Console.WriteLine("Digite um tecla para voltar ao menu principal");
            Console.ReadLine();
            Console.Clear();


        }
        else
        {
            Console.WriteLine("$\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();

        }
    }
}