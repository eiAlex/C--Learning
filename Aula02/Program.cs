//Utilizando o comando doctnet new console é possivel criar um projeto mais completo con todas as dependecias dobnet
// para compilar se utiliza o csc de C Sharp Compile
//

using System;

namespace Aula02 // padrão de name spaces para niveis de organização como se fosse pacotes em java
{
    class Program
    {
        static void Main(string[] args) // um padrão de args[] que recebe um argumento em forma de vetor no arranque 
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Isto é uma string vetorizada" [0]); // 
            
            //este bloco de código abaixo demonstra como utiliza argumentos em tempo de execução para caso tiver de apassar algo ele ja inicia
            if (args.GetLength(0) > 0 ){
                Console.Write(args.GetValue(0));
            }


        }
    }
}
