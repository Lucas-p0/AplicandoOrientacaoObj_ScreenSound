using ScreenSound.Modelos;

namespace AplicandoOrientacaoObj_ScreenSound.Menus;

internal class MenuMostarBandasRegistrada : Menu
{
    internal override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibindoTituloDaOpcao("Exibindo bandas registradas:");

        foreach (string banda in bandasRegistradas.Keys)
        {
            Console.WriteLine($"Banda: {banda}");
        };
        Console.WriteLine($"\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();


    }
}
