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
    public partial class FrmListeDeroulande : Form
    {
        public FrmListeDeroulande()
        {
            InitializeComponent();
        }

        private void FrmListeDeroulande_Load(object sender, EventArgs e)
        {
            string[] Promotion = { "BAC1", "BAC2", "BAC3", "BAC4" };
            cmbList.Items.AddRange(Promotion);
        }

        private void cmbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Votre promotion est "+cmbList.Text,"Affichage Item",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
