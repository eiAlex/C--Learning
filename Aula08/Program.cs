using System;

namespace Aula08
{
    class Program
    {
        static void Main(string[] args)
        {
            int v1, v2, result;
            string nome;

            Console.WriteLine("Escreva seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o primeiro valor: ");
            v1 = int.Parse( Console.ReadLine());

            Console.WriteLine("Digite o segunfo valor: ");
            v2 = Convert.ToInt32( Console.ReadLine());

            result = v1 + v2;

            Console.WriteLine("{0} o seu resultado é: {1}", nome, result);

        }
    }
}
