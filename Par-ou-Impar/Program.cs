using System;

namespace Par_ou_Impar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com um número inteiro: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Par!");
            }

            else { Console.WriteLine("Impar!"); }
        }
            
    }
}
