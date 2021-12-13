using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01KomunikacjaZBaza
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection; // służy do komunikacji z bazą danych 
            SqlCommand command; // przechowyanie poleceń SQL
            SqlDataReader dataReader; // służy do czytania danych z tabelki

            string connString = "Data Source=mssql4.webio.pl,2401;Initial Catalog=tomasz1_zawodnicy;User ID=tomasz1_alxalx;Password=Alxalx1!";
            connection = new SqlConnection(connString);

            command = new SqlCommand("SELECT imie,nazwisko,kraj FROM zawodnicy", connection);
            connection.Open();

            dataReader=  command.ExecuteReader(); // wysyłam polecenie SQL do bazy danych 

          
            int ileKolumnZwrocilWynik = dataReader.FieldCount;
            Console.WriteLine(ileKolumnZwrocilWynik);

            while (dataReader.Read())// czytaj koleny wiersz
            {
                string wynik = Convert.ToString(dataReader.GetValue(0) + " " + dataReader.GetValue(1) + " " + dataReader.GetValue(2));
                Console.WriteLine(wynik);
            }

             
            //dataReader.Read(); // czytaj koleny wiersz
            //wynik = Convert.ToString(dataReader.GetValue(0) + " " + dataReader.GetValue(1) + " " + dataReader.GetValue(2));
            //Console.WriteLine(wynik);


            connection.Close();
            Console.ReadKey();
        }
    }
}
