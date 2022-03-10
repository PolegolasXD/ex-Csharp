using System;

class conversor
{
  static void Main()
  {
    int idade, meses, dias;

    Console.WriteLine("Escreva a sua idade: ");
    idade = int.Parse(Console.ReadLine());

    meses = idade * 12;
    dias = meses * 365;

    Console.WriteLine("\nA sua idade é: " + idade + " ano(s) --- " + meses + " meses --- " + dias + " dias.");
  }
}