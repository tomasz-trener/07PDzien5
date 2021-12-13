using P05AplikacjaZawodnicy.Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05AplikacjaZawodnicy.Repositories
{
    class TrenerzyRepository
    {
        //string connString = "Data Source=.\\sqlexpress;Initial Catalog=a_zawodnicy;integrated security=true";

        string connString = ConfigurationManager.ConnectionStrings["polaczenieZBaza"].ConnectionString;

        private Trener[] MapujTrenerow(object[][] tabela)
        {
            Trener[] trenerzy = new Trener[tabela.Length];
            for (int i = 0; i < tabela.Length; i++)
            {
                Trener t = new Trener();
                t.Id = (int)tabela[i][0];
                t.Imie = (string)tabela[i][1];
                t.Nazwisko = (string)tabela[i][2];

                if (tabela[i][3] == DBNull.Value)
                    t.DataUr = null;
                else
                    t.DataUr = (DateTime)tabela[i][3];
              
                trenerzy[i] = t;
            }
            return trenerzy;
        }

        public Trener[] PobierzTrenerow()
        {
            PolaczenieZBaza pzb = new PolaczenieZBaza(connString);

            object[][] wynik = 
                pzb.
                WykonajPoleceniSQL("SELECT id_trenera, imie_t, nazwisko_t, data_ur_t FROM trenerzy");

            return MapujTrenerow(wynik);                 
        }

        public Trener PobierzTrenera(int id)
        {
            PolaczenieZBaza pzb = new PolaczenieZBaza(connString);

            object[][] wynik =
                pzb.
                WykonajPoleceniSQL($"SELECT id_trenera, imie_t, nazwisko_t, data_ur_t FROM trenerzy where id_trenera={id}");

            return MapujTrenerow(wynik)[0];
        }

        public void DodajTrenera(Trener t)
        {
            PolaczenieZBaza pzb = new PolaczenieZBaza(connString);
            string sql = "insert into trenerzy (imie_t, nazwisko_t,data_ur_t) values " +
                string.Format("('{0}','{1}','{2}')",
                t.Imie, t.Nazwisko,  t.DataUr);
            pzb.WykonajPoleceniSQL(sql);
        }

        public void EdytujTrenera(Trener t)
        {
            PolaczenieZBaza pzb = new PolaczenieZBaza(connString);
            string sql = string.Format("update trenerzy set imie_t = '{0}', nazwisko_t = '{1}' ,data_ur_t = '{2}' where id_trenera={3}",
                t.Imie, t.Nazwisko, t.DataUr, t.Id);
            pzb.WykonajPoleceniSQL(sql);
        }

        public void UsunTrenera(int id)
        {
            PolaczenieZBaza pzb = new PolaczenieZBaza(connString);
            string sql = string.Format("delete trenerzy where id_trenera={0}",
                id);
            pzb.WykonajPoleceniSQL(sql);
        }

    }
}
