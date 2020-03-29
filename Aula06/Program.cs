using System;

namespace Aula06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" \n Hello World \n \t Olá mundo "); // slata um alinha e da uma tabulação 

            int n1, n2, n3;

            n1 = 10; n2 = 20; n3 =  30;

            Console.Write("\n\tn1=\t{0}, \n\tn2=\t{1}, \n\tn3=\t{2} \n", n1, n2, n3 ); // como no python pode ser indexado por indexes passado por meio de chaves 



            double valorCompra = 5.50;
            double valorVenda = 0;
            double lucro = 0.1;
            string produto = "Pastel";

            valorVenda=valorCompra+(valorCompra*lucro);

            Console.WriteLine("Produto..........:{0,15}", produto);
            Console.WriteLine("Val. Compra......:{0,15:c}", valorVenda);
            Console.WriteLine("Lucro............:{0,15:p}", lucro);
            Console.WriteLine("Val. Venda.......:{0,15:c}",valorVenda);




        }
    }
}
