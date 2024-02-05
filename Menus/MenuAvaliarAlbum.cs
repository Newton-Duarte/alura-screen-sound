
class MenuAvaliarAlbum : Menu
{
  public override void Executar(Dictionary<string, Banda> bandasRegistradas)
  {
    base.Executar(bandasRegistradas);
    
    Title("Avaliar Álbum");
    Console.Write("Informe o nome da banda: ");
    string nome = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nome))
    {
      Console.Write("Informe o nome do álbum a ser avaliado: ");
      string album = Console.ReadLine()!;
      Banda banda = bandasRegistradas[nome];

      if (banda.Albuns.Any((album) => album.Equals(album)))
      {
        Album albumDaBanda = banda.Albuns.First((album) => album.Equals(album));
        Console.Write($"Informe uma nota para o álbum {album}: ");
        Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
        
        albumDaBanda.AdicionarNota(nota);
      }
      else
      {
        Console.WriteLine("Álbum não encontrado!");
      }
    }
    else
    {
      Console.WriteLine("Banda não encontrada!");
    }
  }
}