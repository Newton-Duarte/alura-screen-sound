class Podcast
{
  List<Episodio> episodios = new List<Episodio>();
  public string Nome { get; }
  public string Host { get; }
  public int TotalEpisodios => episodios.Count;

  public Podcast(string nome, string host)
  {
    Nome = nome;
    Host = host;
  }

  public void AdicionarEpisodio(Episodio episodio)
  {
    episodios.Add(episodio);
  }

  public void ExibirDetalhes()
  {
    Console.WriteLine($"Podcast: {Nome} - Host: {Host}");

    Console.WriteLine("Episódios\n");
    foreach(Episodio episodio in episodios.OrderBy((episodio) => episodio.Ordem))
    {
      Console.WriteLine($"{episodio.Ordem} - {episodio.Titulo}");
    }

    Console.WriteLine($"\nTotal de episódios: {TotalEpisodios}");
  }
}