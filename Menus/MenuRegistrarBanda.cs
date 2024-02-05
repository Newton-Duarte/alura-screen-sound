
class MenuRegistrarBanda : Menu
{
  public override void Executar(Dictionary<string, Banda> bandasRegistradas)
  {
    base.Executar(bandasRegistradas);
    
    Title("Registrar Banda");
    Console.Write("Informe o nome da banda: ");
    string nome = Console.ReadLine()!;
    
    bandasRegistradas.Add(nome, new Banda(nome));
    Console.WriteLine("\nBanda registrada com sucesso!");
  }
}