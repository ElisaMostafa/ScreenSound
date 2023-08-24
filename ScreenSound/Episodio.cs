class Episodio
{
    public int Duracao { get;  }
    public int Ordem { get;  }
    public string Resumo => $"{Ordem}. {Titulo} ({Duracao} min) - {string.Join(", ", convidados)}"; //join serve para juntar em ordem o conteúdo da lista "convidados", entre parenteses está a especificação de que o que vai ter entre cada nome será uma vírgula  ", " seguido de espaço
    public string Titulo { get;  }

    public Episodio(int ordem, string titulo, int duracao)
    {
        Ordem = ordem;
        Titulo = titulo;
        Duracao = duracao;
       
    }

    List<string> convidados = new();

    public void AdicionarConvidados(string nome)
    {
       
            convidados.Add(nome);
        
        
    }

}