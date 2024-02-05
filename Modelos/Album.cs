class Album : IAvaliavel
{
  private List<Musica> musicas = new List<Musica>();
  private List<Avaliacao> notas = new List<Avaliacao>();
  public string Nome { get; }
  public int DuracaoTotal => musicas.Sum((musica) => musica.Duracao);

  public double Media
  {
    get
    {
      if (musicas.Count > 0) return notas.Average((musica) => musica.Nota);
      else return 0;
    }
  }

  public Album(string nome)
  {
    Nome = nome;
  }

  public void AdicionarMusica(Musica musica)
  {
    musicas.Add(musica);
  }

  public void AdicionarNota(Avaliacao nota)
  {
    notas.Add(nota);
  }

  public void ExibirMusicasDoAlbum()
  {
    Console.WriteLine($"Lista de músicas do álbum: {Nome} ({Media}):\n");
    foreach(Musica musica in musicas)
    {
      Console.WriteLine($"Música: {musica.Nome}");
    }

    Console.WriteLine($"\nA duração total do álbum é de: {DuracaoTotal}");
  }
}