namespace Modelos;
class Musica
{
    public Banda Artista { get; }
    public string Nome { get; }
    public int Duracao { get; set; }
    public bool Disponivel {  get; set; }
    public string DescricaoResumida
    {
        get
        {
            return $"A música {this.Nome} pertence à banda: {this.Artista.Nome}";
        }
    }
    
    public Musica(Banda artista,  string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Artista: {this.Artista}");
        Console.WriteLine($"Nome: {this.Nome}");    
        Console.WriteLine($"Duração: {this.Duracao}s");
        if(this.Disponivel)
        {
            Console.WriteLine("Disponível");
        }
        else 
        {
            Console.WriteLine("Indisponível, assine o plano");
        }
    }
}