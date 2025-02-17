using System;

namespace Exercicio02
{
    class Program
    {
        public static void Main()
        {
            string[] palavra = { "jogo", "mangá", "japônes" };

            foreach (var x in palavra)
            {
                Console.WriteLine(x);
            }
            
            Console.ReadKey();
        }
    }
}