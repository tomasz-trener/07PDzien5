using P05AplikacjaZawodnicy.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05AplikacjaZawodnicy.Repositories
{
    class ZawodnicyRepository
    {

       public Zawodnik[] PobierzZawodnikow()
        {
            string connString = "Data Source=.\\sqlexpress;Initial Catalog=a_zawodnicy;integrated security=true";

            PolaczenieZBaza pzb = new PolaczenieZBaza(connString);

            object[][] wynik = 
                pzb.
                WykonajPoleceniSQL("SELECT id_zawodnika, id_trenera, imie, nazwisko, kraj,data_ur, wzrost,waga FROM zawodnicy");

            Zawodnik[] zawodnicy = new Zawodnik[wynik.Length];
            for (int i = 0; i < wynik.Length; i++)
            {
                Zawodnik z = new Zawodnik();

                z.Id_zawodnika = (int)wynik[i][0];

                if (wynik[i][1] == DBNull.Value)
                    z.Id_trenera = null;
                else
                    z.Id_trenera = (int)wynik[i][1];
               
                
                z.Imie = (string)wynik[i][2];
                z.Nazwisko = (string)wynik[i][3];
                z.Kraj = (string)wynik[i][4];
                z.DataUr = (DateTime)wynik[i][5];
                z.Wzrost = (int)wynik[i][6];
                z.Waga = (int)wynik[i][7];

                zawodnicy[i] =z;
            }
            return zawodnicy;

        
        }

    }
}
