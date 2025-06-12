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
    public partial class FrmPromotion : Form
    {
        public FrmPromotion()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmPromotion_Load(object sender, EventArgs e)
        {
            dgPromotion.DataSource = new Promotion().getPromotion();
            btnModifierPromotion.Enabled = false;
            btnSupprimerPromotion.Enabled = false;
        }

        private void dgPromotion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCode.Text = dgPromotion.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtOption.Text = dgPromotion.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDesignation.Text = dgPromotion.Rows[e.RowIndex].Cells[2].Value.ToString();

            btnModifierPromotion.Enabled = true;
            btnSupprimerPromotion.Enabled = true;
        }

        private void btnAjouterPromotion_Click(object sender, EventArgs e)
        {
            Promotion promotion = new Promotion();
            promotion.Option1 = int.Parse(txtOption.Text);
            promotion.Designation = txtDesignation.Text;
            int resultat = promotion.Ajouter(promotion);
            if (resultat > 0)
            {
                MessageBox.Show("Promotion ajoutée avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearText();
                dgPromotion.DataSource = promotion.getPromotion();
            }
            else 
            {                 
                MessageBox.Show("Erreur lors de l'ajout de la promotion.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void ClearText()
        {
            txtCode.Clear();
            txtOption.Clear();
            txtDesignation.Clear();
            btnModifierPromotion.Enabled = false;
            btnSupprimerPromotion.Enabled = false;
        }

        private void btnModifierPromotion_Click(object sender, EventArgs e)
        {
            Promotion promotion = new Promotion();
            promotion.Code = int.Parse(txtCode.Text);
            promotion.Option1 = int.Parse(txtOption.Text);
            promotion.Designation = txtDesignation.Text;
            int resultat = promotion.Modifier(promotion);
            if (resultat > 0)
            {
                MessageBox.Show("Promotion modifiée avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearText();
                dgPromotion.DataSource = promotion.getPromotion();
            }
            else
            {
                MessageBox.Show("Erreur lors de la modification de la promotion.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSupprimerPromotion_Click(object sender, EventArgs e)
        {
            Promotion promotion = new Promotion();
            promotion.Code = int.Parse(txtCode.Text);
            int resultat = promotion.Supprimer(promotion);
            if (resultat > 0)
            {
                MessageBox.Show("Promotion supprimée avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearText();
                dgPromotion.DataSource = promotion.getPromotion();
            }
            else
            {
                MessageBox.Show("Erreur lors de la suppression de la promotion.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
