class Podcast
{
  List<Episodio> Episodios = new List<Episodio>();
  public string Nome { get; }
  public string Host { get; }
  public int TotalEpisodios => Episodios.Count;

  public Podcast(string nome, string host)
  {
    Nome = nome;
    Host = host;
  }

  public void AdicionarEpisodio(Episodio episodio)
  {
    Episodios.Add(episodio);
  }

  public void ExibirDetalhes()
  {
    Console.WriteLine($"Podcast: {Nome} - Host: {Host}");

    Console.WriteLine("Episódios\n");
    foreach(Episodio episodio in Episodios.OrderBy((episodio) => episodio.Ordem))
    {
      Console.WriteLine($"{episodio.Resumo}");
    }

    Console.WriteLine($"\nTotal de episódios: {TotalEpisodios}");
  }
}