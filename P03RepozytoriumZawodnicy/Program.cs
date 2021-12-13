using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03RepozytoriumZawodnicy
{
    class Program
    {
        static void Main(string[] args)
        {
            ZawodnicyRepository zr = new ZawodnicyRepository();

            Zawodnik[] zawodnicy = zr.PobierzZawodnikow();

            for (int i = 0; i < zawodnicy.Length; i++)
            {
                Console.WriteLine(zawodnicy[i].PrzedstawSie());
            }

            Console.ReadKey();
        }
    }
}
