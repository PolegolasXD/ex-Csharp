using System;

class media
{
  static void Main()
  {
    int number = 0;
    Console.WriteLine("Digite o número a ser verificado: ");
    number = int.Parse(Console.ReadLine());

    if (number % 2 == 0)
    {
      Console.WriteLine("\nO número: " + number + " é par!");
    }
    else
    {
      Console.WriteLine("\nO número: " + number + " é impar!");
    }

  }
}

