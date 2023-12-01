using ScreenSound.Modelos;

namespace AplicandoOrientacaoObj_ScreenSound.Menus;

internal class MenuRegistrarBanda : Menu
{
    internal override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        ExibindoTituloDaOpcao("Registro de bandas");
        Console.Write($"Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        Banda banda = new Banda(nomeDaBanda);
        bandasRegistradas.Add(nomeDaBanda, banda);
        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
        Thread.Sleep(2500);
        Console.Clear();
    }
}
