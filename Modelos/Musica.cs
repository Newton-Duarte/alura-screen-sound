class Musica
{
  public string Nome { get; set; }
  public Banda Artista { get; set; }
  public int Duracao { get; set; }
  public bool Disponivel { get; set; }
  public string DescricaoResumida => $"A música: {Nome} pertence à banda {Artista.Nome}";

  public Musica(string nome, Banda artista)
  {
    Nome = nome;
    Artista = artista;
  }

  public void ExibirFichaTecnica()
  {
    Console.WriteLine($"Nome: {Nome}");
    Console.WriteLine($"Artista: {Artista.Nome}");
    Console.WriteLine($"Duração: {Duracao}");
    if (Disponivel)
    {
      Console.WriteLine("Disponível no plano.");
    }
    else {
      Console.WriteLine("Adquira o plano Plus+");
    }
  }
}