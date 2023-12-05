using AplicandoOrientacaoObj_ScreenSound.Modelos;
using ScreenSound.Modelos;

namespace AplicandoOrientacaoObj_ScreenSound.Menus;


internal class MenuAvaliarBanda : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        //Digite a banda que deseja avaliar
        //Se a banda exstir nodicionario >> atribuir uma nota
        //Senão, voltar ao menu principal
        Console.Clear();
        ExibindoTituloDaOpcao("Avaliar Banda");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;

        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];

            Console.Write("Agora digite o título do álbum: ");
            string tituloAlbum = Console.ReadLine()!;

            if (banda.Albuns.Any(a => a.Nome.Equals(tituloAlbum)))
            {
                Album album = banda.Albuns.First(a => a.Nome.Equals(tituloAlbum));
                Console.Write($"Qual a nota que o álbum {tituloAlbum} merece: ");
                Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
                album.AdicionarNota(nota);
                Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para o álbum {tituloAlbum}");
                Thread.Sleep(2000);
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"\nO álbum {tituloAlbum} não foi encontrado!");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }

    }

}
