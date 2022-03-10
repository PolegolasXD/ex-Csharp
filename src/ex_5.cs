using System;

class penera
{
  static void Main()
  {
    int[] idades = new int[14];

    try
    {
      for (int x = 0; x < idades.Length; x++)
      {
        Console.WriteLine("Insira a " + (x + 1) + " idade: ");
        idades[x] = int.Parse(Console.ReadLine());
      }
    }
    catch
    {
      Console.WriteLine("OPS :( Algo deu errado!");
    }

    Console.Clear();

    for (int x = 0; x < idades.Length; x++)
    {
      if (idades[x] > 18)
      {
        Console.WriteLine("idade: " + x + " = " + idades[x]);
      }
    }

  }
}