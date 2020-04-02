using System;

namespace Aula11
{
    class Program
    {
        static void Main(string[] args)
        {
           //operções de type cast são operações seguras a implicitas não precisão de Cast as explicitas precisçao por nçao ser consideradas seguras 

           int num1 = 100; 
           float num2 = 0;

           num2 = num1 ;
           Console.WriteLine("Print de cat implicito {0}", num2);

           int num3 = 0;
           float num4 = 100.0f;

           num3 = (int) num4;

           Console.WriteLine("Print de cast de explicito {0}", num3);

        }
    }
}
