using System;

namespace desafio_aula_2
{
    class Program
    {
        static void Main(string[] args)
        {
       string nomeAluno;
       float matricula, nota1, nota2, media;

       Console.WriteLine("Digite o nome do aluno: ");
       nomeAluno = Console.ReadLine();

       Console.WriteLine("Digite a matrícula do aluno: ");
       matricula = float.Parse(Console.ReadLine());

       Console.WriteLine("Digite a nota do 1º Bimestre: ");
       nota1 = float.Parse(Console.ReadLine());

       Console.WriteLine("Digite a nota do 2º Bimestre: ");
       nota2 = float.Parse(Console.ReadLine());

       media = (nota1 + nota2)/2;

       if ( media >= 6)
       {
           Console.Write($" {nomeAluno}. Aprovado com média {media}");
       }
       else 
       {
           Console.Write($" {nomeAluno}. Reprovado com média {media}");
       }
        }
    }
}
