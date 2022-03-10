using System;

class average_class
{
  static void Main()
  {
    try
    {

      float soma_idade = 0;
      float media_idade = 0;

      int[] idade_aluno = new int[4];
      string[] nome_aluno = new string[4];

      for (int x = 0; x < 4; x++)
      {
        Console.Clear();
        Console.WriteLine("\nNome do " + (x + 1) + " aluno: \n");
        nome_aluno[x] = Console.ReadLine();

        Console.WriteLine("\nIdade do " + (x + 1) + " aluno: \n");
        idade_aluno[x] = int.Parse(Console.ReadLine());
      }


      for (int x = 0; x < 4; x++)
      {
        soma_idade += idade_aluno[x];
      }

      media_idade = soma_idade / 5;



      Console.Clear();
      Console.WriteLine(" ----- Cálculo da média dos alunos  ----- ");
      Console.WriteLine(" id" + " --- " + "Nome do aluno" + "  --- " + "    idade do aluno\n");

      for (int x = 0; x < 4; x++)
      {
        int size_14 = (nome_aluno[x].Length - 14) * -1;
        string space_string = new string(' ', size_14);

        Console.WriteLine(" " + x + 1 + "  --- " + nome_aluno[x] + space_string + " ---     " + idade_aluno[x]);
      }

      Console.WriteLine("\n A média das idades é: " + media_idade);

    }
    catch
    {
      Console.WriteLine(" OPS :/  Algo deu errado!!");
    }
  }
}

