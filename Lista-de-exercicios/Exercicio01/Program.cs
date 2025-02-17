using System;

namespace Exercicio01
{
    class Program
    {
        public static void Main()
        {
            int[] num = { 1, 4, 5, 6, 7 };

            
            foreach (var x in num)
            {
                Console.WriteLine(x);
            }

            Console.ReadKey(); 
        }
    }
}