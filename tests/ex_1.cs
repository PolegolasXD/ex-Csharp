using System;

class bhaskara
{
  static void Main()
  {
    try
    {
      double a = 0, b, c, delta, x_1, x_2;
      Console.WriteLine("Digite o primeiro valor: ");
      a = Single.Parse(Console.ReadLine());
      Console.WriteLine("Digite o segundo valor: ");
      b = Single.Parse(Console.ReadLine());
      Console.WriteLine("Digite o terceiro valor: ");
      c = Single.Parse(Console.ReadLine());

      //Processo
      delta = Math.Pow(b, 2) - (4 * a * c);
      Console.WriteLine("O valor de delta é: " + delta);

      //Processo 2 
      x_1 = ((-b + Math.Sqrt(delta)) / (2 * a));
      x_2 = ((-b - Math.Sqrt(delta)) / (2 * a));

      Console.WriteLine("Valor x' " + x_1);
      Console.WriteLine("x'' " + x_2);
    }
    catch
    {
      Console.WriteLine("OPS :( Algo deu errado! ");
      System.Environment.Exit(1);
    }
  }
}