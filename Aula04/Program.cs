using System;

namespace Aula04
{
    class Program
    {
       static int num = 100; // este elemento é  global

        static void Main(string[] args)
        {
        //escopod ede ariaveis é como a variável tem area de aatuação

        int num1 = 10; // esste é um exemplo de variável loca

        Console.Write(num);

        }
        void test() {

            Console.Write(num);

        }

    }
}
