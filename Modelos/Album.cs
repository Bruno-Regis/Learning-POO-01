namespace Modelos;
class Album
{
    public string Nome { get; }
    public List<Musica> Musicas = new List<Musica>();
    public int Duracao => Musicas.Sum(m => m.Duracao);

    public Album(string nome) // Método construtor
    {
        Nome = nome;
    }

    public void AdicionarMusica(Musica musica)
    {
        Musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        if (Musicas.Count == 0)
        {
            Console.WriteLine($"Não há nenhuma música cadastrada no album {this.Nome}");
        }
        else
        {
            Console.WriteLine($"Músicas do album {this.Nome}\n");
            foreach(var musica in Musicas)
            {
                Console.WriteLine(musica.Nome);
                Console.WriteLine("");
            }
        }
    }
}