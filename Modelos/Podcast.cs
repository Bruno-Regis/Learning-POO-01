namespace Modelos;
class Podcast
{
    public string Nome { get;}
    public string Host { get;}
    private List<Episodio> ListaEpisodios = new List<Episodio>();
    public List<Episodio> ListaEpisodiosOrdenada => ListaEpisodios.OrderBy(a => a.Numero).ToList();
    private int TotalEpisodios => ListaEpisodios.Count();

    public Podcast(string nome, string host) // Método construtor
    {
        Nome = nome;
        Host = host;
    }

    public void AdicionarEpisodio(Episodio episodio)
    {
        ListaEpisodios.Add(episodio);
        Console.WriteLine($"{episodio.Titulo} adicionado.");
        
    }

    public void ExibirDetalhes()
    {
        System.Console.Clear();
        Console.WriteLine($"Podcast {this.Nome} apresentado por {this.Host}\n");
        
        foreach(Episodio ep in ListaEpisodiosOrdenada)
        {
            Console.WriteLine(ep.Resumo);
        }
        Console.WriteLine($"\nNúmero total de episódios: {this.TotalEpisodios}");
    }
}