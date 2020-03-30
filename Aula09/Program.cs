using System;

namespace Aula09
{
    class Program
    {
        static void Main(string[] args)
        {
            //operações de BitWise
            int num = 4;

            num = num <<2;   // dobra o  dobro
            //para esquerda crese exponencialmente para direita dimiunui
            num = num >> 1; // metade

            Console.WriteLine("Bitwise {0}", num);
        }
    }
}
