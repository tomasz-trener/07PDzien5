using P05AplikacjaZawodnicy.Domain;
using P05AplikacjaZawodnicy.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05AplikacjaZawodnicy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            ZawodnicyRepository zr = new ZawodnicyRepository();
            lbDane.DataSource = zr.PobierzZawodnikow();
            lbDane.DisplayMember = "ImieNazwisko";
        }

        private void lbDane_SelectedIndexChanged(object sender, EventArgs e)
        {
            Zawodnik zaznaczony = (Zawodnik)lbDane.SelectedItem;


            ZawodnicyRepository zr = new ZawodnicyRepository();
            Zawodnik z =  zr.PobierzZawodnika(zaznaczony.Id_zawodnika);

            txtImie.Text = z.Imie;
            txtNazwisko.Text = z.Nazwisko;
            txtKraj.Text = z.Kraj;
            dtpDataUr.Value = z.DataUr;
            txtWaga.Text = Convert.ToString(z.Waga);
            txtWzrost.Text = Convert.ToString(z.Wzrost);

        }
    }
}
