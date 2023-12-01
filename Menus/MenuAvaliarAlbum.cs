using ScreenSound.Modelos;
using AplicandoOrientacaoObj_ScreenSound.Modelos;

namespace AplicandoOrientacaoObj_ScreenSound.Menus;

internal class MenuAvaliarAlbum : Menu
{
    internal override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibindoTituloDaOpcao("Avaliar Álbum");
        Console.Write("Digite o nome que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {

            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.Write("Agora digite o titulo do álbum: ");
            string tituloAlbum = Console.ReadLine()!;
            if (banda.albuns.Any(a => a.Nome.Equals(tituloAlbum)))
            {
                Album album = banda.albuns.First(a => a.Nome.Equals(tituloAlbum));
                Console.Write($"Qual a nota que a banda {tituloAlbum} merece: ");
                Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
                album.AdicionarNota(nota);
                Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para o album {tituloAlbum}");
                Thread.Sleep(2500);
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"O album {tituloAlbum} não foi encontrado!");
                Console.WriteLine($"\nDigite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            };


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
