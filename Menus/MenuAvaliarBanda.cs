
class MenuAvaliarBanda : Menu
{
  public override void Executar(Dictionary<string, Banda> bandasRegistradas)
  {
    base.Executar(bandasRegistradas);
    
    Title("Avaliar Banda");
    Console.Write("Informe o nome da banda a ser avaliada: ");
    string nome = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nome))
    {
      Console.Write("Informe uma nota para a banda: ");
      Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
      
      bandasRegistradas[nome].AdicionarNota(nota);
    }
    else
    {
      Console.WriteLine("Banda não encontrada!");
    }
  }
}