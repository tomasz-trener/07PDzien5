using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02PolaczenieZBaza
{
    class PolaczenieZBaza
    {
        string connString = "Data Source=mssql4.webio.pl,2401;Initial Catalog=tomasz1_zawodnicy;User ID=tomasz1_alxalx;Password=Alxalx1!";

        public PolaczenieZBaza()
        {

        }

        public PolaczenieZBaza(string connString)
        {
            this.connString = connString;
        }

        public object[][] WykonajPoleceniSQL(string sql)
        {
            SqlConnection connection; // służy do komunikacji z bazą danych 
            SqlCommand command; // przechowyanie poleceń SQL
            SqlDataReader dataReader; // służy do czytania danych z tabelki

            connection = new SqlConnection(connString);

            command = new SqlCommand(sql, connection);
            connection.Open();

            dataReader = command.ExecuteReader(); // wysyłam polecenie SQL do bazy danych 


            int liczbaKolumn = dataReader.FieldCount;

            List<object[]> listaWierszy = new List<object[]>();

            while (dataReader.Read())// czytaj koleny wiersz
            {
                object[] komorki = new object[liczbaKolumn];
                for (int i = 0; i < liczbaKolumn; i++)
                    komorki[i] = dataReader.GetValue(i);

                listaWierszy.Add(komorki);
            }

            connection.Close();

            return listaWierszy.ToArray();
        }


    }
}
