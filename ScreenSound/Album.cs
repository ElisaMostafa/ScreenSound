using System.Reflection.Metadata.Ecma335;

class Album
{
    private List<Musica> musicas = new List<Musica>();

    public Album(string nome) // construtor - para que o objeto receba o devido nome no momento que for instanciado
    {
        Nome = nome;
    }
    public string Nome { get;  } //disponivel apenas o metodo get, pois o set será definido no momento que o album for criado
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirAlbum()
    {
        Console.WriteLine($"\nMúsicas do álbum {Nome}\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
        Console.WriteLine($"\nPara ouvir este album inteiro você precisa de {DuracaoTotal} minutos\n");
    }
}