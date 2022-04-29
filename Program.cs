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
                Console.Write("Podaj wysokośc choinki: ");
                if (int.TryParse(Console.ReadLine(), out int a) && a >= 1)
                {

                }
                else
                {

                }
                Console.WriteLine("Chcesz zakończyć program? (tak/nie)");
                koniec = Console.ReadLine();
            }
            while (koniec == "nie");
        }
    }
}
