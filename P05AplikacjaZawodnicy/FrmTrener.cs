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
    public partial class FrmTrener : Form
    {
        Trener trener;

        private void UstawPolaTrenera(Trener z)
        {
            txtImie.Text = z.Imie;
            txtNazwisko.Text = z.Nazwisko;

            if (z.DataUr != null)
            {
                dtpDataUr.Value = (DateTime)z.DataUr;
                dtpDataUr.Visible = true;
            }
            else
            {
                txtDataUr.Visible = true;
            }
        }

        private void ZczytajTrenera(Trener z)
        {
            z.Imie = txtImie.Text;
            z.Nazwisko = txtNazwisko.Text;

            if (dtpDataUr.Visible)
                z.DataUr = dtpDataUr.Value;
            else
                z.DataUr = null;
        }

        public FrmTrener(Trener trener)
        {
            InitializeComponent();
            this.trener = trener;

            UstawPolaTrenera(trener);
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            ZczytajTrenera(trener);
            TrenerzyRepository tr = new TrenerzyRepository();
            tr.EdytujTrenera(trener);

            this.Close();

        }

        private void txtDataUr_Click(object sender, EventArgs e)
        {
            txtDataUr.Visible = false;
            dtpDataUr.Visible = true;
        }
    }
}
