using System;

namespace Cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            Console.Write("Digite aqui a frase para o Cebolinha repetir: ");
            text = Console.ReadLine();

            // ---------------------

            Console.WriteLine("O Cebolinha diz: {0}",text.Replace("r","l").Replace("R","L"));
        }
    }
}
