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
        string connString = "Data Source=.\\sqlexpress;Initial Catalog=a_zawodnicy;integrated security=true";


        private Zawodnik[] MapujZawodnikow(object[][] tabela)
        {
            Zawodnik[] zawodnicy = new Zawodnik[tabela.Length];
            for (int i = 0; i < tabela.Length; i++)
            {
                Zawodnik z = new Zawodnik();

                z.Id_zawodnika = (int)tabela[i][0];

                if (tabela[i][1] == DBNull.Value)
                    z.Id_trenera = null;
                else
                    z.Id_trenera = (int)tabela[i][1];


                z.Imie = (string)tabela[i][2];
                z.Nazwisko = (string)tabela[i][3];
                z.Kraj = (string)tabela[i][4];
                z.DataUr = (DateTime)tabela[i][5];
                z.Wzrost = (int)tabela[i][6];
                z.Waga = (int)tabela[i][7];

                zawodnicy[i] = z;
            }
            return zawodnicy;
        }

        public Zawodnik[] PobierzZawodnikow()
        {
            PolaczenieZBaza pzb = new PolaczenieZBaza(connString);

            object[][] wynik = 
                pzb.
                WykonajPoleceniSQL("SELECT id_zawodnika, id_trenera, imie, nazwisko, kraj,data_ur, wzrost,waga FROM zawodnicy");

            return MapujZawodnikow(wynik);                 
        }

        public Zawodnik PobierzZawodnika(int id)
        {
            PolaczenieZBaza pzb = new PolaczenieZBaza(connString);

            object[][] wynik =
                pzb.
                WykonajPoleceniSQL($"SELECT id_zawodnika, id_trenera, imie, nazwisko, kraj,data_ur, wzrost,waga FROM zawodnicy where id_zawodnika={id}");

            return MapujZawodnikow(wynik)[0];
        }



    }
}
