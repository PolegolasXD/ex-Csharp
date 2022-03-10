using System;

class triangulo
{
  static void Main()
  {
    int base_triangulo, altura_triangulo, area_triangulo;

    Console.WriteLine("Insira a base do triangulo: ");
    base_triangulo = int.Parse(Console.ReadLine());
    Console.WriteLine("Insira a altura do triangulo: ");
    altura_triangulo = int.Parse(Console.ReadLine());
    Console.Clear();

    area_triangulo = base_triangulo * altura_triangulo;

    Console.WriteLine("\nA area do triangulo é: " + area_triangulo);
  }
}
