using ScreenSound.Modelos;

namespace AplicandoOrientacaoObj_ScreenSound.Menus;

internal class MenuSair : Menu
{
    internal override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.WriteLine($"Acabou!!!");
    }
}
