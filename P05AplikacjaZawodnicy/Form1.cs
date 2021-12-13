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

        private void Odswiez()
        {
            ZawodnicyRepository zr = new ZawodnicyRepository();
            lbDane.DataSource = zr.PobierzZawodnikow();
            lbDane.DisplayMember = "ImieNazwisko";
        }

        private void ZczytajZawodnika(Zawodnik z)
        {
            z.Imie = txtImie.Text;
            z.Nazwisko = txtNazwisko.Text;
            z.Kraj = txtKraj.Text;
            z.DataUr = dtpDataUr.Value;
            z.Wzrost = Convert.ToInt32(txtWzrost.Text);
            z.Waga = Convert.ToInt32(txtWaga.Text);
        }

        private void UstawPolaZawodnika(Zawodnik z)
        {
            txtImie.Text = z.Imie;
            txtNazwisko.Text = z.Nazwisko;
            txtKraj.Text = z.Kraj;
            dtpDataUr.Value = z.DataUr;
            txtWaga.Text = Convert.ToString(z.Waga);
            txtWzrost.Text = Convert.ToString(z.Wzrost);
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            Odswiez();
        }

        private void lbDane_SelectedIndexChanged(object sender, EventArgs e)
        {
            Zawodnik zaznaczony = (Zawodnik)lbDane.SelectedItem;
            ZawodnicyRepository zr = new ZawodnicyRepository();
            Zawodnik z =  zr.PobierzZawodnika(zaznaczony.Id_zawodnika);
            UstawPolaZawodnika(z);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            ZawodnicyRepository zr = new ZawodnicyRepository();
            Zawodnik z = new Zawodnik();
            ZczytajZawodnika(z);
            zr.DodajZawodnika(z);
            Odswiez();
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            Zawodnik z = (Zawodnik)lbDane.SelectedItem;
            ZczytajZawodnika(z);
            ZawodnicyRepository zr = new ZawodnicyRepository();   
            zr.EdytujZawodnika(z);
            Odswiez();
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            Zawodnik z = (Zawodnik)lbDane.SelectedItem;
            ZawodnicyRepository zr = new ZawodnicyRepository();
            zr.UsunZawodnika(z.Id_zawodnika);
            Odswiez();
        }
    }
}
