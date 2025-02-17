using System;

namespace Exercicio05
{
    class Program
    {
        public static void Main()
        {
            double[] num = { 1, 5, 7, 8, 9 };

            double soma = 0;

            foreach (var x in num)
            {
                soma += x;
            }
            double media = soma / num.Length;
            Console.WriteLine($"A média da lista é: {media}");
            Console.ReadKey();
        }
    }
}