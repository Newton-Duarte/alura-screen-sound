Dictionary<string, Banda> bandas = new Dictionary<string, Banda>();
Dictionary<int, Menu> opcoes = new Dictionary<int, Menu>();

opcoes.Add(1, new MenuRegistrarBanda());
opcoes.Add(2, new MenuRegistrarAlbum());
opcoes.Add(3, new MenuAvaliarBanda());
opcoes.Add(4, new MenuListarBandas());
opcoes.Add(5, new MenuExibirDetalhes());
opcoes.Add(9, new MenuSair());

Menu();

void Menu()
{
  Title(@"Bem-vindo ao Screen Sound");
  Console.WriteLine("1 - Registrar banda");
  Console.WriteLine("2 - Registrar album");
  Console.WriteLine("3 - Avaliar banda");
  Console.WriteLine("4 - Listar bandas");
  Console.WriteLine("5 - Exibir detalhes da banda");
  Console.WriteLine("9 - Sair");
  Console.Write("\nDigite a opção: ");
  
  int opcao = int.Parse(Console.ReadLine()!);

  Menu menu = opcoes[opcao];
  menu.Executar(bandas);
  
  if (opcao < 9) BackToMenu();
}

void Title(string title)
{
  int titleLength = title.Length;

  Console.WriteLine("".PadLeft(titleLength, '*'));
  Console.WriteLine(title);
  Console.WriteLine("".PadLeft(titleLength, '*'));
  Console.WriteLine("\n");
}

void BackToMenu()
{
  Console.WriteLine("Aperte qualquer tecla para voltar ao menu");
  Console.ReadKey();
  Menu();
}