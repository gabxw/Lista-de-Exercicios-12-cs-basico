using System;

namespace Exercicio04
{
    class Program
    {
        public static void Main()
        {
            string[] palavras = { "paralelepípedo", "hipopotamo", "elefante", "gabinete" };

            string comprimento = palavras[0];



            foreach (var x in palavras)

            {
                if(x.Length > comprimento.Length)
                {
                    comprimento = x;
                }
            }
            Console.WriteLine($"A maior palavra é: {c}");
            Console.ReadKey();
        }
    }
}