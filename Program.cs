using Modelos;

Podcast devcast = new ("dev.cast", "Bruno");
Episodio ep3 = new ("ep3", 3, 55, "Hello world y otras cositas mas");
Episodio ep1 = new ("ep1", 1, 100, "hello world");

ep1.AdicionarConvidados("João");
ep1.AdicionarConvidados("José");

Episodio ep2 = new ("ep2", 2, 150, "Episódio interessante, fala da história do C#");
ep1.AdicionarConvidados("Jacó");
ep2.AdicionarConvidados("Joshua");
ep2.AdicionarConvidados("Magda");
ep3.AdicionarConvidados("José");
devcast.AdicionarEpisodio(ep3);
devcast.AdicionarEpisodio(ep1);
devcast.AdicionarEpisodio(ep2);
devcast.ExibirDetalhes();
Console.WriteLine("----------------------------------------------------");
Console.WriteLine();
Banda metallica = new("Metallica");
Musica nothingElseMatters = new(metallica, "Nothing Else Matters");
nothingElseMatters.Duracao = 7;
Album theBlackAlbum = new("The Black Album");
theBlackAlbum.AdicionarMusica(nothingElseMatters);
metallica.AdicionarAlbum(theBlackAlbum);
metallica.ExibirDiscografia();

