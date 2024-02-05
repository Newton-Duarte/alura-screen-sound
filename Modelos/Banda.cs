class Banda
{
  private List<Album> Albuns = new List<Album>();
  private List<Avaliacao> Notas = new List<Avaliacao>();
  public string Nome { get; }

  public Banda(string nome)
  {
    Nome = nome;
  }

  public void AdicionarAlbum(Album album)
  {
    Albuns.Add(album);
  }

  public void AvaliarBanda(Avaliacao nota)
  {
    Notas.Add(nota);
  }

  public void ExibirDiscografia()
  {
    Console.WriteLine($"Discografia da banda: {Nome} ({Notas.Average((nota) => nota.Nota)})");
    foreach(Album album in Albuns)
    {
      Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
    }
  }
}