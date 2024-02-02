class Banda
{
  private List<Album> albums = new List<Album>();
  public string Nome { get; }

  public Banda(string nome)
  {
    Nome = nome;
  }

  public void AdicionarAlbum(Album album)
  {
    albums.Add(album);
  }

  public void ExibirDiscografia()
  {
    Console.WriteLine($"Discografia da banda: {Nome}");
    foreach(Album album in albums)
    {
      Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
    }
  }
}