

Episodio ep1 = new(1, "Técnicas de facilitação", 45);
ep1.AdicionarConvidados("Maria");
ep1.AdicionarConvidados("João");


Episodio ep2 = new(2, "Técnicas de aprendizado", 67);
ep2.AdicionarConvidados("Marcelo");
ep2.AdicionarConvidados("Marcos");
ep2.AdicionarConvidados("Flávio");


Episodio ep3 = new(3, "Técnicas de prática", 98);
ep3.AdicionarConvidados("Madalena");
ep3.AdicionarConvidados("Iraci");
ep3.AdicionarConvidados("Ana");



Podcast podcast = new("Podcast Especial", "Daniel");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.AdicionarEpisodio(ep3);
podcast.ExibirDetalhes();



