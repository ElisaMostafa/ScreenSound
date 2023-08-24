class Podcast
{
    List<Episodio> episodioList = new List<Episodio>();

    public string Host { get; }
    public string Nome { get; }
    public int TotalEpisodios => episodioList.Count;

    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodioList.Add(episodio);
    }
    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast: {Nome} apresentado por: {Host}");

        foreach (Episodio episodio in episodioList.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"\n\nEste podcast possui de {Convert.ToString(TotalEpisodios)} episódios");
    }



}