class Episodio
{
  List<string> Convidados = new List<string>();

  public int Ordem { get; }
  public string Titulo { get; }
  public int Duracao { get; }
  public string Resumo => $"{Ordem}. {Titulo} ({Duracao} min) - Convidados: {String.Join(", ", Convidados)}";

  public Episodio(int ordem, string titulo, int duracao)
  {
    Ordem = ordem;
    Titulo = titulo;
    Duracao = duracao;
  }

  public void AdicionarConvidado(string convidado)
  {
    Convidados.Add(convidado);
  }
}