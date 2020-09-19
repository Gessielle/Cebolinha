using System;

namespace Cebolinha
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string frase;

            Console.Write("Digite qualquer coisa: ");
            frase = Console.ReadLine();
            Console.Write("\n");

            Console.WriteLine($"{frase.Replace("r", "l").Replace("R", "L")}");

            Console.WriteLine("Presione Enter para sair");
            Console.ReadKey();


        }
    }
}
