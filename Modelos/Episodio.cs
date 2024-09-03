namespace Modelos;
class Episodio
{
    public string Titulo { get;}
    public int Numero { get;}
    public int Duracao { get; }
    public string Resumo => $"{this.Numero} | {this.Titulo} | {this.Duracao} minutos | {string.Join(", ", Convidados)}";
    
    private List<string> Convidados = new();

    public Episodio(string titulo, int numero, int duracao, string resumo) //Método construtor
    {
        Titulo = titulo;
        Numero = numero;
        Duracao = duracao;
    }

    public void AdicionarConvidados(string convidado)
    {
        Convidados.Add(convidado);
    }

    public void ExibirConvidados()
    {
        foreach(var convidado in Convidados)
        {
            Console.WriteLine(convidado);
        }
    }
}
