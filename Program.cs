Dictionary<string, Banda> bandas = new Dictionary<string, Banda>();

Menu();

void Menu()
{
  Title(@"Bem-vindo ao Screen Sound");
  Console.WriteLine("1 - Registrar banda");
  Console.WriteLine("2 - Registrar album");
  Console.WriteLine("3 - Listar bandas");
  Console.WriteLine("4 - Avaliar banda");
  Console.WriteLine("5 - Exibir detalhes da banda");
  Console.WriteLine("9 - Sair");
  Console.Write("\nDigite a opção: ");
  
  int opcao = int.Parse(Console.ReadLine()!);

  switch(opcao)
  {
    case 1:
      RegistrarBanda();
      break;
    case 2:
      RegistrarAlbum();
      break;
    case 3:
      ListarBandas();
      break;
    case 4:
      AvaliarBanda();
      break;
    case 5:
      ExibirDetalhes();
      break;
    case 9:
      Console.WriteLine("Tchau tchau! :)");
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
  
  bandas.Add(nome, new Banda(nome));
  Console.WriteLine("\nBanda registrada com sucesso!");
  BackToMenu();
}

void RegistrarAlbum()
{
  Console.Clear();
  Title("Registrar Album");
  Console.Write("Informe o nome da banda para registrar o álbum: ");
  string nome = Console.ReadLine()!;

  if (bandas.ContainsKey(nome))
  {
    Console.Write("Informe o nome do álbum da banda: ");
    string album = Console.ReadLine()!;
    bandas[nome].AdicionarAlbum(new Album(album));
    Console.WriteLine($"\nAlbum {album} registrado com sucesso!");
    BackToMenu();
  }
  else
  {
    Console.WriteLine($"\nA banda {nome} não foi encontrada!");
    BackToMenu();
  }
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
    Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
    
    bandas[nome].AvaliarBanda(nota);
  }
  else {
    Console.WriteLine("Banda não encontrada!");
  }
  
  BackToMenu();
}

void ExibirDetalhes()
{
  Console.Clear();
  Title("Média da banda");
  Console.Write("Informe o nome da banda para saber os detalhes: ");
  string nome = Console.ReadLine()!;

  if (bandas.ContainsKey(nome)) {
    bandas[nome].ExibirDiscografia();
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