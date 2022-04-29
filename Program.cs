using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Opis programu:
            Console.WriteLine("Program drukuje choinkę z gwiazdek według podanej wysokości.");
            Console.WriteLine();

            // Zadeklarowanie zmiennych:
            string koniec;
            do
            {
                Console.Write("Podaj wysokość choinki: ");
                if (int.TryParse(Console.ReadLine(), out int a) && a >= 1)
                {
                    for (int j = 1; j <= a; j++)
                    {
                        for (int i = 1; i <= a - j; i++)
                        {
                            Console.Write(" ");
                        }
                        for (int i = 1; i <= 2 * j - 1; i++)
                        {
                            Console.Write("*");
                        }
                        for (int i = 1; i <= a - j; i++)
                        {
                            Console.Write(" ");
                        }
                        Console.WriteLine();
                    }
                    for (int i = 1; i <= 2; i++)
                    {
                        for (int j = 1; j <= a - 1; j++)
                        {
                            Console.Write(" ");
                        }
                        Console.WriteLine("|");
                    }
                }
                else
                {
                    Console.WriteLine("Niepoprawna wysokość!");
                }
                Console.WriteLine("Chcesz zakończyć program? (tak/nie)");
                koniec = Console.ReadLine();
            }
            while (koniec == "nie");
        }
    }
}
