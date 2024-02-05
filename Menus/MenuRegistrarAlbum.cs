
class MenuRegistrarAlbum : Menu
{
  public override void Executar(Dictionary<string, Banda> bandasRegistradas)
  {
    base.Executar(bandasRegistradas);

    Title("Registrar Album");
    Console.Write("Informe o nome da banda para registrar o álbum: ");
    string nome = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nome))
    {
      Console.Write("Informe o nome do álbum da banda: ");
      string album = Console.ReadLine()!;
      bandasRegistradas[nome].AdicionarAlbum(new Album(album));
      Console.WriteLine($"\nAlbum {album} registrado com sucesso!");
    }
    else
    {
      Console.WriteLine($"\nA banda {nome} não foi encontrada!");
    }
  }
}