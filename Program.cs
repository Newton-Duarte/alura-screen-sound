Dictionary<string, List<int>> bandas = new Dictionary<string, List<int>>();

// Menu();

// Banda queen = new Banda("Queen");
// Album albumDoQueen = new Album("A night at the opera");
// Musica musica1 = new Musica("Love of my life", queen)
// {
//   Duracao = 213,
//   Disponivel = true,
// };

// Musica musica2 = new Musica("Bohemian Rhapsody", queen)
// {
//   Duracao = 354,
//   Disponivel = false
// };

// albumDoQueen.AdicionarMusica(musica1);
// albumDoQueen.AdicionarMusica(musica2);
// queen.AdicionarAlbum(albumDoQueen);

// musica1.ExibirFichaTecnica();
// musica2.ExibirFichaTecnica();
// albumDoQueen.ExibirMusicasDoAlbum();
// queen.ExibirDiscografia();

Podcast devSemFronteiras = new Podcast("Dev Sem Fronteiras", "Newton Duarte");
Episodio episodio1 = new Episodio(1, "Como se tornar um dev sem fronteiras", 45);
episodio1.AdicionarConvidado("John Doe");
episodio1.AdicionarConvidado("Jane Doe");

devSemFronteiras.AdicionarEpisodio(episodio1);
devSemFronteiras.ExibirDetalhes();

void Menu()
{
  Title(@"Bem-vindo ao Screen Sound");
  Console.WriteLine("1 - Registrar banda");
  Console.WriteLine("2 - Listar bandas");
  Console.WriteLine("3 - Avaliar banda");
  Console.WriteLine("4 - Exibir média da banda");
  Console.WriteLine("9 - Sair");
  Console.Write("\nDigite a opção: ");
  
  int opcao = int.Parse(Console.ReadLine()!);

  switch(opcao)
  {
    case 1:
      RegistrarBanda();
      break;
    case 2:
      ListarBandas();
      break;
    case 3:
      AvaliarBanda();
      break;
    case 4:
      ExibirMediaDaBanda();
      break;
    default:
      Console.WriteLine("Opção inválida");
      BackToMenu();
      break;
  }
}

void Title(string title)
{
  int titleLength = title.Length;

  Console.WriteLine("".PadLeft(titleLength, '*'));
  Console.WriteLine(title);
  Console.WriteLine("".PadLeft(titleLength, '*'));
  Console.WriteLine("\n");
}

void RegistrarBanda()
{
  Console.Clear();
  Title("Registrar Banda");
  Console.Write("Informe o nome da banda: ");
  string nome = Console.ReadLine()!;
  
  bandas.Add(nome, new List<int>());
  Console.WriteLine("\nBanda registrada com sucesso!");
  BackToMenu();
}

void ListarBandas()
{
  Console.Clear();
  Title("Lista de Bandas");
  foreach(string banda in bandas.Keys)
  {
    Console.WriteLine(banda);
  }

  Console.WriteLine("\n--fim da lista");
  BackToMenu();
}

void AvaliarBanda()
{
  Console.Clear();
  Title("Avaliar Banda");
  Console.Write("Informe o nome da banda a ser avaliada: ");
  string nome = Console.ReadLine()!;

  if (bandas.ContainsKey(nome)) {
    Console.Write("Informe uma nota para a banda: ");
    int nota = int.Parse(Console.ReadLine()!);
    
    bandas[nome].Add(nota);
  }
  else {
    Console.WriteLine("Banda não encontrada!");
  }
  
  BackToMenu();
}

void ExibirMediaDaBanda()
{
  Console.Clear();
  Title("Média da banda");
  Console.Write("Informe o nome da banda para saber a média: ");
  string nome = Console.ReadLine()!;

  if (bandas.ContainsKey(nome)) {
    double media = bandas[nome].Average();
    
    Console.WriteLine($"A média da banda {nome} é: {media.ToString("F2")}");
  }
  else {
    Console.WriteLine("Banda não encontrada!");
  }

  BackToMenu();
}

void BackToMenu()
{
  Console.WriteLine("Aperte qualquer tecla para voltar ao menu");
  Console.ReadKey();
  Menu();
}