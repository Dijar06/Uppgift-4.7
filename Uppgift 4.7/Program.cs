using System;

namespace Uppgift4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett meddelande som du vill se vertikalt:");
            string meddelande = Console.ReadLine();
            Console.WriteLine("Hur många steg åt höger ska ditt meddelande flyttas?");
            int steg = int.Parse(Console.ReadLine());

            for (int i  = 0; i < meddelande.Length; i++)
            {
                for (int j = 0; j < steg; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(meddelande[i]);
            }
        }
    }
}
