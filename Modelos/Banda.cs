using AplicandoOrientacaoObj_ScreenSound.Modelos;

namespace ScreenSound.Modelos
{
    // Classe que representa uma banda musical
    internal class Banda : IAvaliavel
    {
        // Lista de álbuns pertencentes à banda
        public List<Album> albuns = new();

        // Lista de notas atribuídas à banda
        public List<Avaliacao> notas = new();

        // Propriedade somente leitura que armazena o nome da banda
        public string Nome { get; }

        public double Media => throw new NotImplementedException();

        // Propriedade calculada que retorna a média das notas atribuídas à banda
        // public double Media
        // {
        //     get
        //     {
        //         if (notas.Count == 0) return 0;
        //         else return notas.Average(a => a.Nota);
        //     }
        // }

        // Construtor da classe Banda que recebe o nome como parâmetro
        public Banda(string nome)
        {
            Nome = nome;
        }

        // Método para adicionar um álbum à lista de álbuns da banda
        public void AdicionarAlbum(Album album)
        {
            albuns.Add(album);
        }

        // Método para exibir a discografia da banda na console
        public void ExibirDiscografia()
        {
            Console.WriteLine($"Discografia da banda: {Nome}");

            // Loop para iterar sobre cada álbum e exibir informações
            foreach (Album album in albuns)
            {
                Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
            }
        }

        // Método para adicionar uma nota à lista de notas da banda
        public void AdicionarNota(Avaliacao nota)
        {
            notas.Add(nota);
        }
    }
}
