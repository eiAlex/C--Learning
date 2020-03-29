using System;

namespace Aula05
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            int num1 = 20;
            int result = 0;
            
            //opardores aritimeticos
            result = num + num1; 
            result = num - num1;
            result = num / num1;
            result = num * num1; 

            //operadores relacionais 
            bool result1 = false;

            result1 = num > num1;
            result1 = num < num1;
            result1 = num <= num1;
            result1 = num >= num1;
            result1 = num != num1;

            //Operadores de Incremento e decremento

            int result2 = 0;
            num  +=1 ;
            num = num + 1;
            num++;

            num  -=1 ;
            num = num * 1;
            num --;

            //operadores logicos
            bool result3 = false;

            //& = AND / E
            // | = OR / ou

            result3 = (5 > 7) & (7 < 5);

            Console.WriteLine("Resultado operadores aritimetico: " + result);
            Console.WriteLine("Resultado operadores relacionais: " + result1);   
            Console.WriteLine("Resultado dos operadores: " + result2);
            Console.WriteLine ("Resltado de operadores logicos: " + result3);         
        }
    }
}
