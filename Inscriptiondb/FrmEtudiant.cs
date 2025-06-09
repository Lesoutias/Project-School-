using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inscriptiondb
{
    public partial class FrmEtudiant : Form
    {
        public FrmEtudiant()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {

        }

        private void cmbEtatCivil_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void FrmEtudiant_Load(object sender, EventArgs e)
        {
            string[] Ecivil = { "Marie", "Celibataire", "Divorce", "Veuf" };
            cmbEtatCivil.Items.AddRange(Ecivil);
            cmbEtatCivil.Text = Ecivil[1];
        }
    }
}
