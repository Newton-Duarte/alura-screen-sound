
class MenuExibirDetalhes : Menu
{
  public override void Executar(Dictionary<string, Banda> bandasRegistradas)
  {
    base.Executar(bandasRegistradas);

    Title("Exibir detalhes da banda");
    Console.Write("Informe o nome da banda para saber os detalhes: ");
    string nome = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nome)) {
      bandasRegistradas[nome].ExibirDiscografia();
    }
    else {
      Console.WriteLine("Banda não encontrada!");
    }
  }
}