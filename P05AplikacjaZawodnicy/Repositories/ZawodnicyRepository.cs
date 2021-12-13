using P05AplikacjaZawodnicy.Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05AplikacjaZawodnicy.Repositories
{
    class ZawodnicyRepository
    {
        //string connString = "Data Source=.\\sqlexpress;Initial Catalog=a_zawodnicy;integrated security=true";

        string connString = ConfigurationManager.ConnectionStrings["polaczenieZBaza"].ConnectionString;

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

        public void DodajZawodnika(Zawodnik z)
        {
            PolaczenieZBaza pzb = new PolaczenieZBaza(connString);
            string sql = "insert into zawodnicy (imie, nazwisko,kraj,data_ur,wzrost,waga) values " +
                string.Format("('{0}','{1}','{2}','{3}',{4},{5})",
                z.Imie, z.Nazwisko, z.Kraj, z.DataUr, z.Wzrost, z.Waga);
            pzb.WykonajPoleceniSQL(sql);
        }

        public void EdytujZawodnika(Zawodnik z)
        {
            PolaczenieZBaza pzb = new PolaczenieZBaza(connString);
            string sql = string.Format("update zawodnicy set imie = '{0}', nazwisko = '{1}' ,kraj = '{2}' ,data_ur = '{3}', wzrost={4},waga={5} where id_zawodnika={6}",
                z.Imie, z.Nazwisko, z.Kraj, z.DataUr, z.Wzrost, z.Waga, z.Id_zawodnika);
            pzb.WykonajPoleceniSQL(sql);
        }

        public void UsunZawodnika(int id)
        {
            PolaczenieZBaza pzb = new PolaczenieZBaza(connString);
            string sql = string.Format("delete zawodnicy where id_zawodnika={0}",
                id);
            pzb.WykonajPoleceniSQL(sql);
        }

    }
}
