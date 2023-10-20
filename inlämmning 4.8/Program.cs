using System;
namespace inlämmning_4._8
{
    class program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Ange triangelns sidlängd");
            int sidlängd = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < sidlängd; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
