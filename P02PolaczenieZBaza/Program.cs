using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02PolaczenieZBaza
{
    class Program
    {
        static void Main(string[] args)
        {
            PolaczenieZBaza pzb = new PolaczenieZBaza();

            object[][] wynik =  pzb.WykonajPoleceniSQL("select imie, nazwisko, kraj from zawodnicy order by kraj");

            //for (int i = 0; i < wynik.Length; i++)
            //{
            //    for (int j = 0; j < wynik[i].Length; j++)
            //        Console.Write(wynik[i][j] + " ");

            //    Console.WriteLine();
            //}

            for (int i = 0; i < wynik.Length; i++)
                Console.WriteLine(string.Join(" ", wynik[i]));

            Console.ReadKey();
        }
    }
}
