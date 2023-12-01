using ScreenSound.Modelos;

namespace AplicandoOrientacaoObj_ScreenSound.Menus;
internal class MenuRegristarAlbum : Menu
{
    internal override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibindoTituloDaOpcao("Registro de álbum");
        Console.Write("Digite a banda cujo o álbum deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Console.Write("Agora digite o titulo do álbum: ");
            string tituloAlbum = Console.ReadLine()!;
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.WriteLine($"O álgum {tituloAlbum} da banda {nomeDaBanda} foi registrado!");
            Thread.Sleep(2500);
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine($"\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
