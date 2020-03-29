using System;

namespace Aula03
{
    class Program
    {
        static void Main(string[] args)
        {
        // o  C# é uma liguagem fortemente tipada onde a variávell tem de possuir um tipo de dado , por custume devese inicializar a variável.

        int num = 0;
        char  letra = 'a';
        float valor = 10.30f; // deve se informado f no final
        double valor1 = 12.1;
        byte n1 = 12; // entre 0 e 255
        String  texto = " Stringnão é um tipo primitivo"; // conjuto de caracteres

        // pode-se declarar variaveis em mesma linha do mesmo tipo
        int res = 0, num1, num2;

        num1 = 111;
        num2=0; // se a variável não for estanciada não tem iniciação do objeto. consequentimente funciona mas não entrega a informação.
        res = num1 + num2;

        Console.WriteLine("Prnt " + res);





        Console.Write(num); // escreve na tela na mesma linha
        Console.WriteLine (texto); //imprime na tela com uma linha

    


        }


    }
}
