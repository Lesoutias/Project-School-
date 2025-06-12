using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace Inscriptiondb
{
    public partial class FrmEtudiant : Form
    {
        Etudiant etudiant = new Etudiant();
        public FrmEtudiant()
        {
            InitializeComponent();
        }

        private void Valeur()
        {
            etudiant.Matricule = txtMatricule.Text;
            etudiant.Nom = txtNom.Text;
            etudiant.Postnom = txtPostNom.Text;
            etudiant.Prenom = txtPrenom.Text;
            etudiant.Etatcivile = cmbEtatCivil.Text;
            etudiant.Datenaissance = txtDateNaiss.Text;
            etudiant.Lieunaissance = txtLieuNaiss.Text;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Valeur();
            int resultat = etudiant.AjouterEtudiant(etudiant);
            if (resultat > 0)
            {
                MessageBox.Show("Etudiant ajoutée avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearText();
                dgvEtudiant.DataSource = etudiant.getEtudiant();
            }
            else
            {
                MessageBox.Show("Erreur lors de l'ajout de l'Etudiant.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbEtatCivil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmEtudiant_Load(object sender, EventArgs e)
        {
            string[] Ecivil = { "Marie", "Celibataire", "Divorce", "Veuf" };
            cmbEtatCivil.Items.AddRange(Ecivil);
            cmbEtatCivil.Text = Ecivil[1];
            dgvEtudiant.DataSource = etudiant.getEtudiant();
            btnModifier.Enabled = false;
            btnSupprimer.Enabled = false;
        }

        private void dgvEtudiant_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMatricule.Text = dgvEtudiant.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNom.Text = dgvEtudiant.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPostNom.Text = dgvEtudiant.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPrenom.Text = dgvEtudiant.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbEtatCivil.Text = dgvEtudiant.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtDateNaiss.Text = dgvEtudiant.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtLieuNaiss.Text = dgvEtudiant.Rows[e.RowIndex].Cells[6].Value.ToString();

            btnSupprimer.Enabled = true;
            btnModifier.Enabled = true;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            Valeur();
            int resultat = etudiant.ModifierEtudiant(etudiant);
            if (resultat > 0)
            {
                MessageBox.Show("Etudiant modifié avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearText();
                dgvEtudiant.DataSource = etudiant.getEtudiant();
            }
            else
            {
                MessageBox.Show("Erreur lors de la modification de l'Etudiant.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            btnModifier.Enabled = false;
            btnSupprimer.Enabled = false;
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            etudiant.Matricule = txtMatricule.Text; 
            int resultat = etudiant.SupprimerEtudiant(etudiant);
            if (resultat > 0)
            {
                MessageBox.Show("Etudiant supprimé avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearText();
                dgvEtudiant.DataSource = etudiant.getEtudiant();
            }
            else
            {
                MessageBox.Show("Erreur lors de la supression de l'Etudiant.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            btnModifier.Enabled = false;
            btnSupprimer.Enabled = false;
        }

        private void ClearText()
        {
            txtMatricule.Text = "";
            txtNom.Text = "";
            txtPostNom.Text = "";
            txtPrenom.Text = "";
            cmbEtatCivil.Text = "";
            txtDateNaiss.Text = "";
            txtLieuNaiss.Text = "";
        }
    }
}
