namespace Modelos;
class Banda
{
    public string Nome { get; }
    private List<Album> Albums = new List<Album>();

    public Banda(string nome ) // Método construtor
    {
        Nome = nome;
    }

    public void AdicionarAlbum(Album album)
    {
        Albums.Add( album );
        Console.WriteLine($"{album.Nome} adicionado à lista de albums da banda {this.Nome}");
    }

    public void ExibirDiscografia()
    {
        if ( Albums.Count == 0 )
        {
            Console.WriteLine("A banda não possui nenhum album registrado");
        }
        else
        {
            Console.WriteLine($"Discografia da banda: {this.Nome}");
            foreach(Album album in Albums )
            {
                Console.WriteLine($"Album: {album.Nome} | Duração: {album.Duracao}");
            }
        }
    }
}