using System;

namespace Exercicio03
{
    class Program
    {
        public static void Main()
        {
            int[] inteiro = { 3,5,6,7,8 };

            int maior = inteiro[0];

            foreach (var x in inteiro)
            {
                if (x > maior)
                {
                    maior = x;
                }
            }
            Console.WriteLine($"O maior número é: {maior}");
            Console.ReadKey();
        }
    }
}