using System;

namespace Aula12
{
    class Program
    {
        static void Main(string[] args)
        {
        double nota = 0 ;
        string resultado = "Reprovado" ;

        nota = Double.Parse(Console.ReadLine());

        if ((nota) >= 60){
            resultado = "Aprovado";
        }

        Console.WriteLine("O Aluno está: {0}", resultado);
        }
    }
}
