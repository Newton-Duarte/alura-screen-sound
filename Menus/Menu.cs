class Menu
{
  public virtual void Executar(Dictionary<string, Banda> bandasRegistradas)
  {
    Console.Clear();
  }

  public void Title(string title)
  {
    int titleLength = title.Length;

    Console.WriteLine("".PadLeft(titleLength, '*'));
    Console.WriteLine(title);
    Console.WriteLine("".PadLeft(titleLength, '*'));
    Console.WriteLine("\n");
  }
}