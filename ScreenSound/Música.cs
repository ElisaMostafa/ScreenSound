class Musica
{
    public Musica(Banda artista, string nome) { 
     Artista = artista;
     Nome = nome;
    }

    public string Nome {get;}
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; } //properties sempore devem ter a primeira letra maiúscula
    public string DescricaoResumida => $"A música {Nome} pertence ao artista {Artista.Nome}"; //atribuir valor ao get sem ter que escrever toda a estruta escrita normalmente (=>). Chamado Lambda



    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponivel no plano");
        }
        else
        {
            Console.WriteLine("Adiquira o plano plus+");
        }        
    }
    public void ExibirNomeEArtista()
    {
        Console.WriteLine($"Nome: {Nome} - Artista: {Artista}");
    }
}

