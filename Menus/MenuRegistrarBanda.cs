using ScreenSound.Modelos;
using OpenAI_API;

namespace AplicandoOrientacaoObj_ScreenSound.Menus;

internal class MenuRegistrarBanda : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibindoTituloDaOpcao("Registro de bandas");
        Console.Write($"Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        Banda banda = new(nomeDaBanda);

        var client = new OpenAIAPI("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");
        var chat = client.Chat.CreateConversation();

        chat.AppendSystemMessage($"Resuma a {nomeDaBanda} Oficina G3 em 1 parágrafo. Adote um estilo informal.");
        string response = chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult();
        banda.Resumo = response;
        Console.WriteLine(response);


        bandasRegistradas.Add(nomeDaBanda, banda);
        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
        Thread.Sleep(2500);
        Console.Clear();
    }
}
