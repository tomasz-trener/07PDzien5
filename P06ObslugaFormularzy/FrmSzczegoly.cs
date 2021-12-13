using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P06ObslugaFormularzy
{
    public partial class FrmSzczegoly : Form
    {
        FrmStartowy frmStartowy;
        public FrmSzczegoly(FrmStartowy frmStartowy)
        {
            InitializeComponent();
            this.frmStartowy = frmStartowy;
        }

        private void FrmSzczegoly_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmStartowy.FrmSzczegoly = null;
        }
    }
}
