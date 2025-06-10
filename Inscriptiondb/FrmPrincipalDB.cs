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
    public partial class FrmPrincipalDB : Form
    {
        public FrmPrincipalDB()
        {
            InitializeComponent();
        }

        private void fenetresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmEtudiant frmEtudiant = new FrmEtudiant();
            frmEtudiant.MdiParent = this;
            frmEtudiant.StartPosition = FormStartPosition.CenterScreen;
            frmEtudiant.Show();
        }

        private void inscriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInscription frmInscription = new FrmInscription();
            frmInscription.MdiParent = this;
            frmInscription.StartPosition = FormStartPosition.CenterScreen;
            frmInscription.Show();
        }

        private void promotionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPromotion frmPromotion = new FrmPromotion();
            frmPromotion.MdiParent = this;
            frmPromotion.StartPosition = FormStartPosition.CenterScreen;
            frmPromotion.Show();
        }

        private void FrmPrincipalDB_Load(object sender, EventArgs e)
        {
            if (DataAccess.Instance.OpenConection())
            {
                MessageBox.Show("Connexion reussie", "Connection",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("Connection Echoue", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
