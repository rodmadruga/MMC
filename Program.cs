using System;

namespace MMC
{
    class Program
    {
        static void Main(string[] args)
        {
            //2520 é o menor número que pode ser dividido por cada um dos números de 1 a 10 sem qualquer resto.
            //Qual é o menor número positivo que é divisível por todos os números de 1 a 20?
            
            var divisores = 0;
            var valor = 2520;
            var de = 1;
            var ate = 20;
            while (divisores != ate)
            {
                divisores = 0;
                valor += 2;
                for (var i = de; i <= ate; i++)
                {
                    if (valor % i == 0)
                        divisores++;
                }
            }
            Console.WriteLine("Valor: " + valor);
        }
    }
}
