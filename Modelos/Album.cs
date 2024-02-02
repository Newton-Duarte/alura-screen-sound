class Album
{
  private List<Musica> musicas = new List<Musica>();
  public string Nome { get; }
  public int DuracaoTotal => musicas.Sum((musica) => musica.Duracao);

  public Album(string nome)
  {
    Nome = nome;
  }

  public void AdicionarMusica(Musica musica)
  {
    musicas.Add(musica);
  }

  public void ExibirMusicasDoAlbum()
  {
    Console.WriteLine($"Lista de músicas do álbum: {Nome}:\n");
    foreach(Musica musica in musicas)
    {
      Console.WriteLine($"Música: {musica.Nome}");
    }

    Console.WriteLine($"\nA duração total do álbum é de: {DuracaoTotal}");
  }
}