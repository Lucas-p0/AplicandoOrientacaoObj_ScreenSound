namespace ScreenSound.Modelos
{
    // Classe que representa uma banda musical
    class Banda
    {
        // Lista de álbuns pertencentes à banda
        private List<Album> albums = new();

        // Lista de notas atribuídas à banda
        private List<int> notas = new();

        // Propriedade somente leitura que armazena o nome da banda
        public string Nome { get; }

        // Propriedade calculada que retorna a média das notas atribuídas à banda
        public double Media => notas.Average();

        // Construtor da classe Banda que recebe o nome como parâmetro
        public Banda(string nome)
        {
            Nome = nome;
        }

        // Método para adicionar um álbum à lista de álbuns da banda
        public void AdicionarAlbum(Album album)
        {
            albums.Add(album);
        }

        // Método para exibir a discografia da banda na console
        public void ExibirDiscografia()
        {
            Console.WriteLine($"Discografia da banda: {Nome}");

            // Loop para iterar sobre cada álbum e exibir informações
            foreach (Album album in albums)
            {
                Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
            }
        }

        // Método para adicionar uma nota à lista de notas da banda
        public void AdicionarNota(int nota)
        {
            notas.Add(nota);
        }
    }
}
