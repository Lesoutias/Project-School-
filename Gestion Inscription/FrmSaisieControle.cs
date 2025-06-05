using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Inscription
{
    public partial class FrmSaisieControle : Form
    {
        public FrmSaisieControle()
        {
            InitializeComponent();
        }

        private void btnquitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtSaisie_TextChanged(object sender, EventArgs e)
        {
            lblControle.Text = txtSaisie.Text;
        }

        private void FrmSaisieControle_Load(object sender, EventArgs e)
        {
            txtSaisie.Focus();
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            txtSaisie.Text = "";
        }
    }
}
