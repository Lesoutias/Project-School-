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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Chargement initial", "Formulaire Principal", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Voulez vous vraiment fermer?", "Fermeture", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (res == DialogResult.No)
            { 
                e.Cancel = true;
            }
        }
    }
}
