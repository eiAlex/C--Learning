using System;

namespace Aula10
{
    class Program
    {
        //trabalhando com enumeradores eles possuem elementos e index

        enum DiasSemana{Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sabado};

        static void Main(string[] args)
        {
            //acessando o emun
            DiasSemana ds = DiasSemana.Domingo; // chamado do enum
            DiasSemana ds1= (DiasSemana) 3; // podemos fazer cast de conversão do dia da semna
            int ds2 = (int)DiasSemana.Segunda; // posso chamar o index do enumerador, bastando utilizar uma cast de converssão.


            Console.WriteLine("Dias da semnha de um enum {0} , dias da semana indexada {1}, dias da semna recebendo o valor inteiro do enum {2}", ds, ds1, ds2);


        }
    }
}
