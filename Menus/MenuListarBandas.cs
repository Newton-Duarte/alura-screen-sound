
class MenuListarBandas : Menu
{
  public override void Executar(Dictionary<string, Banda> bandasRegistradas)
  {
    base.Executar(bandasRegistradas);

    Title("Lista de Bandas");
    foreach(string banda in bandasRegistradas.Keys)
    {
      Console.WriteLine(banda);
    }

    Console.WriteLine("\n---fim da lista---");
  }
}